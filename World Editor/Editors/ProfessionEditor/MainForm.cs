using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using DBCLib.Structures335;
using World_Editor.DBC;

namespace World_Editor.ProfessionEditor
{
    public partial class MainForm : Form
    {
        ResourceManager Loc = new ResourceManager("World_Editor.Editors.ProfessionEditor.ProfessionEditorLocal", System.Reflection.Assembly.GetExecutingAssembly());
        private Skill loadedSkill = new Skill();

        public MainForm()
        {
            InitializeComponent();
        }

        public static ProfessionEditor.MainForm m_professionsEditor;
        public static ProfessionEditor.MainForm GetChildInstance()
        {
            if (m_professionsEditor == null)
                m_professionsEditor = new MainForm();

            return m_professionsEditor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadProfessionEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("LoadDbcError"));
                this.Close();
            }

            foreach (SkillLineEntry entry in DBC.DBCStores.SkillLine.Records)
            {
                if (entry.CategoryId == 11 || entry.Id == 185 /*|| entry.Id == 129*/)//Secourisme buggé
                    lstSkills.Items.Add(entry);
            }
            lstSkills.Sorted = true;
            if (lstRecipes.Items.Count == 0)
                activateComposants(false);
        }

        private void lstSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSkills.SelectedItem == null)
                return;

            //Nettoyage du tab Recettes à faire !
            SkillLineEntry selectedSkill = (SkillLineEntry)lstSkills.SelectedItem;

            loadedSkill.load(selectedSkill.Id);

            // SpellFocusObject
            foreach (var sfo in DBCStores.SpellFocusObject.Records)
            {
                cbSpellFocus.Items.Add(sfo);
            }

            // Enable info tab;
            txtSkillName.Enabled = true;
            txtSkillVerb.Enabled = true;
            txtSkillDescription.Enabled = true;
            cbLinkable.Enabled = true;
            txtReqLvl.Enabled = true;
            txtClassMask.Enabled = true;
            txtRaceMask.Enabled = true;

            // Info tab

            txtSkillName.Text = loadedSkill.Line.Name;
            txtSkillDescription.Text = loadedSkill.Line.Description;
            txtSkillVerb.Text = loadedSkill.Line.AlternateVerb;

            if (loadedSkill.Line.CanLink == 1)
            {
                cbLinkable.Checked = true;
            }

            txtReqLvl.Text = loadedSkill.RaceClassInfo.ReqLevel.ToString();
            txtRaceMask.Text = loadedSkill.RaceClassInfo.RaceMask.ToString();
            txtClassMask.Text = loadedSkill.RaceClassInfo.ClassMask.ToString();

            // Chargement des recettes

            lstRecipes.Items.Clear();

            foreach (var recipe in loadedSkill.Recipes.Values)
            {
                lstRecipes.Items.Add(recipe);
            }
            activateComposants();
        }

        private void btnRaceMask_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskRaces d = new World_Editor.Dialogs.MaskRaces();
            d.MaskRacesValue = uint.Parse(txtRaceMask.Text);
            d.ShowDialog();
            txtRaceMask.Text = d.MaskRacesValue.ToString();
        }

        private void btnClassMask_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskClasses d = new World_Editor.Dialogs.MaskClasses();
            d.MaskClassesValue = uint.Parse(txtClassMask.Text);
            d.ShowDialog();
            txtClassMask.Text = d.MaskClassesValue.ToString();
        }

        private void txtSkillName_TextChanged(object sender, EventArgs e)
        {
            DBCStores.SkillLine[loadedSkill.Line.Id].Name = txtSkillName.Text;
        }

        private void txtSkillVerb_TextChanged(object sender, EventArgs e)
        {
            DBCStores.SkillLine[loadedSkill.Line.Id].AlternateVerb = txtSkillVerb.Text;
        }

        private void txtSkillDescription_TextChanged(object sender, EventArgs e)
        {
            DBCStores.SkillLine[loadedSkill.Line.Id].Description = txtSkillDescription.Text;
        }

        private void txtReqLvl_TextChanged(object sender, EventArgs e)
        {
            DBCStores.SkillRaceClassInfo[loadedSkill.RaceClassInfo.Id].ReqLevel = uint.Parse(txtReqLvl.Text);
        }

        private void txtRaceMask_TextChanged(object sender, EventArgs e)
        {
            DBCStores.SkillRaceClassInfo[loadedSkill.RaceClassInfo.Id].RaceMask = uint.Parse(txtRaceMask.Text);
        }

        private void txtClassMask_TextChanged(object sender, EventArgs e)
        {
            DBCStores.SkillRaceClassInfo[loadedSkill.RaceClassInfo.Id].ClassMask = uint.Parse(txtClassMask.Text);
        }

        private void cbLinkable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLinkable.CheckState == CheckState.Checked)
            {
                DBCStores.SkillLine[loadedSkill.Line.Id].CanLink = 1;
            }
            else
            {
                DBCStores.SkillLine[loadedSkill.Line.Id].CanLink = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBCStores.SaveProfessionEditorFiles();
        }

        #region recettes
        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            txtRecipeEntry.Text = recipe.spell.Id.ToString();
            txtRecipeName.Text = recipe.spell.SpellName;

            txtReagent1.Text = recipe.spell.Reagent[0].ToString();
            txtReagent2.Text = recipe.spell.Reagent[1].ToString();
            txtReagent3.Text = recipe.spell.Reagent[2].ToString();
            txtReagent4.Text = recipe.spell.Reagent[3].ToString();
            txtReagent5.Text = recipe.spell.Reagent[4].ToString();
            txtReagent6.Text = recipe.spell.Reagent[5].ToString();
            txtReagent7.Text = recipe.spell.Reagent[6].ToString();
            txtReagent8.Text = recipe.spell.Reagent[7].ToString();

            txtCount1.Text = recipe.spell.ReagentCount[0].ToString();
            txtCount2.Text = recipe.spell.ReagentCount[1].ToString();
            txtCount3.Text = recipe.spell.ReagentCount[2].ToString();
            txtCount4.Text = recipe.spell.ReagentCount[3].ToString();
            txtCount5.Text = recipe.spell.ReagentCount[4].ToString();
            txtCount6.Text = recipe.spell.ReagentCount[5].ToString();
            txtCount7.Text = recipe.spell.ReagentCount[6].ToString();
            txtCount8.Text = recipe.spell.ReagentCount[7].ToString();

            txtRecipeResult.Text = recipe.spell.EffectItemType[0].ToString();

            txtRecipeGreen.Text = recipe.ability.SkillGreenLevel.ToString();
            txtRecipeGrey.Text = recipe.ability.SkillGreyLevel.ToString();

            if (recipe.ability.AcquireMethod == 0)
            {
                chbBase.Checked = false;
            }
            else
                chbBase.Checked = true;

            txtTool1.Text = recipe.spell.Totem[0].ToString();
            txtTool2.Text = recipe.spell.Totem[1].ToString();

            foreach (object item in cbSpellFocus.Items)
            {
                SpellFocusObjectEntry sfoe = (SpellFocusObjectEntry)item;

                if (recipe.spell.RequiresSpellFocus == sfoe.Id)
                {
                    cbSpellFocus.SelectedItem = item;
                }
            }
        }

        private void txtRecipeName_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.SpellName = txtRecipeName.Text;
        }

        private void txtRecipeEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecipeGreen_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.ability.SkillGreenLevel = uint.Parse(txtRecipeGreen.Text);
        }

        private void txtRecipeGrey_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.ability.SkillGreyLevel = uint.Parse(txtRecipeGrey.Text);
        }

        private void txtRecipeResult_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.EffectItemType[0] = uint.Parse(txtRecipeResult.Text);
        }

        private void chbBase_CheckedChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            if (chbBase.CheckState == CheckState.Checked)
            {
                recipe.ability.AcquireMethod = 1;
            }
            else
            {
                recipe.ability.AcquireMethod = 0;
            }
        }

        private void cbSpellFocus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            if (cbSpellFocus.SelectedItem != null)
            {
                SpellFocusObjectEntry sfo = (SpellFocusObjectEntry)cbSpellFocus.SelectedItem;

                recipe.spell.RequiresSpellFocus = sfo.Id;
            }
            else
            {
                recipe.spell.RequiresSpellFocus = 0;
            }
        }

        private void txtReagent1_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Reagent[0] = int.Parse(txtReagent1.Text);
        }

        private void txtReagent2_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Reagent[1] = int.Parse(txtReagent2.Text);
        }

        private void txtReagent3_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Reagent[2] = int.Parse(txtReagent3.Text);
        }

        private void txtReagent4_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Reagent[3] = int.Parse(txtReagent4.Text);
        }

        private void txtReagent5_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Reagent[4] = int.Parse(txtReagent5.Text);
        }

        private void txtReagent6_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Reagent[5] = int.Parse(txtReagent6.Text);
        }

        private void txtReagent7_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Reagent[6] = int.Parse(txtReagent7.Text);
        }

        private void txtReagent8_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Reagent[7] = int.Parse(txtReagent8.Text);
        }

        private void txtCount1_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.ReagentCount[0] = uint.Parse(txtCount1.Text);
        }

        private void txtCount2_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.ReagentCount[1] = uint.Parse(txtCount2.Text);
        }

        private void txtCount3_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.ReagentCount[2] = uint.Parse(txtCount3.Text);
        }

        private void txtCount4_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.ReagentCount[3] = uint.Parse(txtCount4.Text);
        }

        private void txtCount5_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.ReagentCount[4] = uint.Parse(txtCount5.Text);
        }

        private void txtCount6_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.ReagentCount[5] = uint.Parse(txtCount6.Text);
        }

        private void txtCount7_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.ReagentCount[6] = uint.Parse(txtCount7.Text);
        }

        private void txtCount8_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.ReagentCount[7] = uint.Parse(txtCount8.Text);
        }

        private void txtTool1_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Totem[0] = uint.Parse(txtTool1.Text);
        }

        private void txtTool2_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            recipe.spell.Totem[1] = uint.Parse(txtTool2.Text);
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            SpellEntry sp = new SpellEntry();
            SkillLineAbilityEntry sla = new SkillLineAbilityEntry();

            sp.InitRecipe();

            sp.Id = DBCStores.Spell.MaxKey + 1;
            sp.SpellName = "Nouvelle recette";

            sla.Id = DBCStores.SkillLineAbility.MaxKey + 1;
            sla.SkillId = loadedSkill.Line.Id;
            sla.SpellId = sp.Id;
            sla.MinSkillLineRank = 1;

            Recipe recipe = new Recipe(sp, sla);

            loadedSkill.Recipes.Add(sp.Id, recipe);
            lstRecipes.Items.Add(recipe);

            DBCStores.Spell.AddEntry(sp.Id, sp);
            DBCStores.SkillLineAbility.AddEntry(sla.Id, sla);

            lstRecipes.SelectedItem = recipe;
            activateComposants();
        }

        private void btnDelRecipe_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette recette ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            if (choix == System.Windows.Forms.DialogResult.OK)
            {
                if (lstRecipes.SelectedItem == null)
                    return;

                Recipe recipe = (Recipe)lstRecipes.SelectedItem;

                loadedSkill.Recipes.Remove(recipe.spell.Id);
                loadedSkill.Spells.Remove(recipe.spell.Id);
                loadedSkill.Abilities.Remove(recipe.ability.Id);

                DBCStores.Spell.RemoveEntry(recipe.spell.Id);
                DBCStores.SkillLineAbility.RemoveEntry(recipe.ability.Id);

                lstRecipes.Items.Remove(recipe);
            }
            if (lstRecipes.Items.Count == 0)
                activateComposants(false);
        }
        #endregion

        private void tpSpell_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_professionsEditor = null;
        }

        private void btnNewProf_Click(object sender, EventArgs e)
        {
            uint linkable = 0;
            if(cbLinkable.Checked)
                linkable = 1;
            try
            {
                SkillLineEntry skl = new SkillLineEntry
                {
                    Id = DBCStores.SkillLine.MaxKey + 1,
                    CategoryId = 11,
                    SkillCostId = 0x0,
                    Name = Loc.GetString("NewProfession"),
                    Description = Loc.GetString("NewProfessionDescription"),
                    SpellIcon = 339,
                    AlternateVerb = "",
                    CanLink = linkable
                };

                lstSkills.Items.Add(skl);
                DBCStores.SkillLine.AddEntry(skl.Id, skl);

                SkillRaceClassInfoEntry sklrc = new SkillRaceClassInfoEntry
                {
                    Id = DBCStores.SkillRaceClassInfo.MaxKey + 1,
                    SkillId = skl.Id,
                    RaceMask = 2047,
                    ClassMask = 1535,
                    Flags = 0xA0,
                    ReqLevel = 0,
                    SkillTierId = 41,
                    SkillCostId = 0x0
                };

                DBCStores.SkillRaceClassInfo.AddEntry(sklrc.Id, sklrc);

                lstSkills.SelectedItem = skl;
                activateComposants(false);
            }
            catch(Exception error)
            {
                MessageBox.Show(Loc.GetString("AddProfessionError") + "\n" + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelProf_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce métier ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            if (choix == System.Windows.Forms.DialogResult.OK)
            {
                if (lstSkills.SelectedItem == null)
                    return;
                SkillLineEntry skillLine = (SkillLineEntry)lstSkills.SelectedItem;
                DBCStores.SkillLine.RemoveEntry(skillLine.Id);

                lstSkills.Items.Remove(skillLine);
            }
        }

        private void activateComposants(bool value = true)
        {
            // Activation des box d'informations
            grpInfos.Enabled = value;
            grpComposants.Enabled = value;
            grpFacultatif.Enabled = value;
            btnDelRecipe.Enabled = value;
        }
    }
}
