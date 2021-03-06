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
using World_Editor.Editors;
using World_Editor.Dialogs;
using World_Editor.Stormlib;
using MDS.cBlp2;
using World_Editor.Editors.ProfessionEditor;

namespace World_Editor.ProfessionEditor
{
    public partial class MainForm : EditorForm
    {
        public static MainForm m_professionEditor;
        List<String> rangsDeMetiers = new List<string> 
        {
            "Apprenti",
            "Compagnon",
            "Expert",
            "Artisan",
            "Maître",
            "Grand Maître"
        };

        List<String> descriptionDesRangs = new List<string> 
        {
            "Vous permet d'évoluer vos talents vers un niveau de compétence de 75 au maximum.",
            "Vous permet d'évoluer vos talents vers un niveau de compétence de 150 au maximum.",
            "Vous permet d'évoluer vos talents vers un niveau de compétence de 225 au maximum.",
            "Vous permet d'évoluer vos talents vers un niveau de compétence de 300 au maximum.",
            "Vous permet d'évoluer vos talents vers un niveau de compétence de 375 au maximum.",
            "Vous permet d'évoluer vos talents vers un niveau de compétence de 450 au maximum."
        };
        ResourceManager Loc = new ResourceManager("World_Editor.Editors.ProfessionEditor.ProfessionEditorLocal", System.Reflection.Assembly.GetExecutingAssembly());
        private Skill loadedSkill = new Skill();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadProfessionEditorFiles();
                DBCStores.SpellIcon.LoadData();
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
            lstSkills.SelectedIndex = lstSkills.Items.Count - 1;
            if (!Properties.Settings.Default.OptionUseDatabase)
            {
                btnSearchRecipe1.Enabled = false;
                btnSearchRecipe2.Enabled = false;
                btnSearchRecipe3.Enabled = false;
                btnSearchRecipe4.Enabled = false;
                btnSearchRecipe5.Enabled = false;
                btnSearchRecipe6.Enabled = false;
                btnSearchRecipe7.Enabled = false;
                btnSearchRecipe8.Enabled = false;
                btnSearchResultRecipe.Enabled = false;
            }
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
            txtIcon.Text = loadedSkill.Line.SpellIcon.ToString();

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
            lstRecipes.SelectedIndex = lstRecipes.Items.Count - 1;
            lstRecipes.Sorted = true;
            activateComposants();
            labelNbRecipes.Text = lstRecipes.Items.Count.ToString() + " recettes";
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
            SkillLineEntry s = (SkillLineEntry)lstSkills.Items[lstSkills.SelectedIndex];
            s.Name = txtSkillName.Text;

            DBCStores.SkillLine.ReplaceEntry(s.Id, s);
            lstSkills.Items[lstSkills.SelectedIndex] = s;
            //DBCStores.SkillLine[loadedSkill.Line.Id].Name = txtSkillName.Text;
        }

        private void txtIcon_TextChanged(object sender, EventArgs e)
        {
            DBCStores.SkillLine[loadedSkill.Line.Id].SpellIcon = uint.Parse(txtIcon.Text);

            try
            {
                SpellIconEntry sp = DBCStores.SpellIcon.Records.Single(i => i.Id.ToString().Equals(txtIcon.Text));
                if (MPQFile.Exists(sp.IconPath + ".blp"))
                    pbIcon.Image = Blp2.FromStream(new MPQFile(sp.IconPath + ".blp"));
                else
                    pbIcon.Image = Blp2.FromStream(new MPQFile("Interface\\InventoryItems\\WoWUnknownItem01.blp"));
            }
            catch (Exception )
            {

            }
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
            try
            {
                DBCStores.SaveProfessionEditorFiles();
                MessageBox.Show("Sauvegarde terminée !", "Réussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message);
            }
        }

        #region recettes
        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            txtRecipeEntry.Text = recipe.spell.Id.ToString();
            txtRecipeName.Text = recipe.spell.SpellName;
            txtRecipeIcon.Text = recipe.spell.SpellIconID.ToString();

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

        private void txtRecipeGreen_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            if (!txtRecipeGreen.Text.Equals(""))
                recipe.ability.SkillGreenLevel = uint.Parse(txtRecipeGreen.Text);
        }

        private void txtRecipeGrey_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            if (!txtRecipeGrey.Text.Equals(""))
                recipe.ability.SkillGreyLevel = uint.Parse(txtRecipeGrey.Text);
        }

        private void txtRecipeResult_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;

            if(!txtRecipeResult.Text.Equals(""))
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
            if(!txtReagent1.Text.Equals(""))
                recipe.spell.Reagent[0] = int.Parse(txtReagent1.Text);
        }

        private void txtReagent2_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtReagent2.Text.Equals(""))
                recipe.spell.Reagent[1] = int.Parse(txtReagent2.Text);
        }

        private void txtReagent3_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtReagent3.Text.Equals(""))
                recipe.spell.Reagent[2] = int.Parse(txtReagent3.Text);
        }

        private void txtReagent4_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtReagent4.Text.Equals(""))
                recipe.spell.Reagent[3] = int.Parse(txtReagent4.Text);
        }

        private void txtReagent5_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtReagent5.Text.Equals(""))
                recipe.spell.Reagent[4] = int.Parse(txtReagent5.Text);
        }

        private void txtReagent6_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtReagent6.Text.Equals(""))
                recipe.spell.Reagent[5] = int.Parse(txtReagent6.Text);
        }

        private void txtReagent7_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtReagent7.Text.Equals(""))
                recipe.spell.Reagent[6] = int.Parse(txtReagent7.Text);
        }

        private void txtReagent8_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtReagent8.Text.Equals(""))
                recipe.spell.Reagent[7] = int.Parse(txtReagent8.Text);
        }

        private void txtCount1_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtCount1.Text.Equals(""))
                recipe.spell.ReagentCount[0] = uint.Parse(txtCount1.Text);
        }

        private void txtCount2_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtCount2.Text.Equals(""))
                recipe.spell.ReagentCount[1] = uint.Parse(txtCount2.Text);
        }

        private void txtCount3_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtCount3.Text.Equals(""))
                recipe.spell.ReagentCount[2] = uint.Parse(txtCount3.Text);
        }

        private void txtCount4_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtCount4.Text.Equals(""))
                recipe.spell.ReagentCount[3] = uint.Parse(txtCount4.Text);
        }

        private void txtCount5_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtCount5.Text.Equals(""))
                recipe.spell.ReagentCount[4] = uint.Parse(txtCount5.Text);
        }

        private void txtCount6_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtCount6.Text.Equals(""))
                recipe.spell.ReagentCount[5] = uint.Parse(txtCount6.Text);
        }

        private void txtCount7_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtCount7.Text.Equals(""))
                recipe.spell.ReagentCount[6] = uint.Parse(txtCount7.Text);
        }

        private void txtCount8_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtCount8.Text.Equals(""))
                recipe.spell.ReagentCount[7] = uint.Parse(txtCount8.Text);
        }

        private void txtTool1_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtTool1.Text.Equals(""))
                recipe.spell.Totem[0] = uint.Parse(txtTool1.Text);
        }

        private void txtTool2_TextChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem == null)
                return;

            Recipe recipe = (Recipe)lstRecipes.SelectedItem;
            if (!txtTool2.Text.Equals(""))
                recipe.spell.Totem[1] = uint.Parse(txtTool2.Text);
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            SpellEntry sp = new SpellEntry();
            SkillLineAbilityEntry sla = new SkillLineAbilityEntry();

            sp.InitRecipe();

            sp.Id = DBCStores.Spell.MaxKey + 1;
            sp.SpellName = Loc.GetString("NewRecipe");
            sp.Rank = "";
            sp.Description = "";
            sp.ToolTip = "";

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

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveProfessionEditorFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde des fichiers DBCs : " + ex.Message);
            }
        }
        #endregion

        private void tpSpell_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNewProf_Click(object sender, EventArgs e)
        {
            uint linkable = 0;
            if(cbLinkable.Checked)
                linkable = 1;
            try
            {
                //Définition du métier dans SkillLine.dbc
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

                //Définition des autorisations du métier dans SkillRaceClassInfo.dbc
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

                //Ajout de 12 lignes :
                //6 lignes de définition des niveaux de sorts : Aprenti, Compagnon, Expert, Artisan, Maître, Grand Maître
                for (int i = 0; i < 6; i++)
                {
                    SpellEntry spell = new SpellEntry();
                    spell.InitJobRanks();

                    spell.Id = DBCStores.Spell.MaxKey + 1;
                    spell.SkillId = skl.Id;
                    spell.SpellIconID = 339;
                    spell.SpellName = skl.Name;
                    spell.Rank = rangsDeMetiers[i];
                    spell.Description = descriptionDesRangs[i];
                    spell.ToolTip = "";
                    spell.SkillRank = i;
                    DBCStores.Spell.AddEntry(spell.Id, spell);

                    //6 lignes de définition des sorts qui apprennent les niveaux de sorts
                    SpellEntry spellLevel = new SpellEntry();
                    if (i == 0)
                    {
                        spellLevel.InitJobSpellRanks(0x40100);
                    }
                    else if (i == 5)
                    {
                        spellLevel.InitJobSpellRanks(0x40100, 0x0);
                    }
                    else
                        spellLevel.InitJobSpellRanks();

                    spellLevel.Id = DBCStores.Spell.MaxKey + 1;
                    spellLevel.SkillId = skl.Id;
                    spellLevel.SpellSkillId = spell.Id;
                    spellLevel.SpellIconID = 339;
                    spellLevel.SpellName = rangsDeMetiers[i] + " " + skl.Name;
                    spellLevel.Rank = "";
                    spellLevel.Description = "";
                    spellLevel.ToolTip = "";
                    spellLevel.SkillRank = i;
                    DBCStores.Spell.AddEntry(spellLevel.Id, spellLevel);

                    //Définition de la chaine des sorts d'apprentissage
                    SkillLineAbilityEntry skla = new SkillLineAbilityEntry();
                    skla.Id = DBCStores.SkillLineAbility.MaxKey + 1;
                    skla.SkillId = skl.Id;
                    skla.SpellId = spell.Id;
                    skla.RequiredClasses = 0;
                    skla.RequiredRaces = 0;
                    skla.MinSkillLineRank = 1;
                    if(i ==5)
                        skla.SpellParent = 0;
                    else
                        skla.SpellParent = spell.Id + 2;
                    skla.AcquireMethod = 0x0;
                    skla.SkillGreyLevel = 0;
                    skla.SkillGreenLevel = 0;
                    DBCStores.SkillLineAbility.AddEntry(skla.Id, skla);
                }

                lstSkills.SelectedItem = skl;
                lstRecipes.SelectedIndex = lstRecipes.Items.Count - 1;
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
            lstRecipes.SelectedIndex = lstRecipes.Items.Count - 1;
        }

        private void activateComposants(bool value = true)
        {
            // Activation des box d'informations
            grpInfos.Enabled = value;
            grpComposants.Enabled = value;
            grpFacultatif.Enabled = value;
            btnDelRecipe.Enabled = value;
        }

        private void btnIcons_Click(object sender, EventArgs e)
        {
            SpellIconDialog d = new SpellIconDialog(Misc.ParseToUInt(txtIcon.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtIcon.Text = d.choosenIcon.ToString();
        }

        private void btnSearchRecipe1_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtReagent1.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtReagent1.Text = s.choosenItem.ToString();
        }

        private void btnSearchRecipe2_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtReagent2.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtReagent2.Text = s.choosenItem.ToString();
        }

        private void btnSearchRecipe3_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtReagent3.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtReagent3.Text = s.choosenItem.ToString();
        }

        private void btnSearchRecipe4_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtReagent4.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtReagent4.Text = s.choosenItem.ToString();
        }

        private void btnSearchRecipe5_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtReagent5.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtReagent5.Text = s.choosenItem.ToString();
        }

        private void btnSearchRecipe6_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtReagent6.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtReagent6.Text = s.choosenItem.ToString();
        }

        private void btnSearchRecipe7_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtReagent7.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtReagent7.Text = s.choosenItem.ToString();
        }

        private void btnSearchRecipe8_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtReagent8.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtReagent8.Text = s.choosenItem.ToString();
        }

        private void btnSearchResultRecipe_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtRecipeResult.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtRecipeResult.Text = s.choosenItem.ToString();
        }

        private void btnRecipeIcon_Click(object sender, EventArgs e)
        {
            SpellIconDialog d = new SpellIconDialog(Misc.ParseToUInt(txtRecipeIcon.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtRecipeIcon.Text = d.choosenIcon.ToString();
        }
    }
}
