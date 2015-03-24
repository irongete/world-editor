using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;
using World_Editor.Editors;
using DBCLib.Structures335;
using World_Editor.Dialogs;

namespace World_Editor.GemsEditor
{
    public partial class MainForm : EditorForm
    {
        public static MainForm m_gemsEditor;
        ResourceManager Loc = new ResourceManager("World_Editor.Editors.GemsEditor.GemsEditorLocal", System.Reflection.Assembly.GetExecutingAssembly());
        
        #region Enums

        enum EnchantStatsFlags
        {
            Health = 1,
            Mana = 2,
            Agility = 3,
            Strength = 4,
            Intellect = 5,
            Spirit = 6,
            Stamina = 7,
            DefenseRating = 12,
            DodgeRating = 13,
            ParryRating = 14,
            ShieldBlockRating = 15,
            MeleeHitRating = 16,
            RangedHitRating = 17,
            SpellHitRating = 18,
            MeleeCriticalStrikeRating = 19,
            RangedCriticalStrikeRating = 20,
            SpellCriticalStrikeRating = 21,
            MeleeHitAvoidanceRating = 22,
            RangedHitAvoidanceRating = 23,
            SpellHitAvoidanceRating = 24,
            MeleeCriticalAvoidanceRating = 25,
            RangedCriticalAvoidanceRating = 26,
            SpellCriticalAvoidanceRating = 27,
            MeleeHasteRating = 28,
            RangedHasteRating = 29,
            SpellHasteRating = 30,
            HitRating = 31,
            CriticalStrikeRating = 32,
            HitAvoidanceRating = 33,
            CriticalAvoidanceRating = 34,
            ResilienceRating = 35,
            HasteRating = 36,
            ExpertiseRating = 37,
            AttackPower = 38,
            RangedPower = 39,
            FeralAttackPower = 40,
            DamageDone = 41,
            HealingDone = 42,
            ManaEvery5Seconds = 43,
            ArmorPenetration = 44,
            SpellPower = 45,
            HealthEvery5Seconds = 46,
            SpellPenetration = 47,
            BlockValue = 48
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadGemsEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("LoadDbcError"));
                this.Close();
            }
            foreach (SpellItemEnchantmentEntry entry in DBC.DBCStores.SpellItemEnchantment.Records)
            {
                lstGems.Items.Add(entry);
            }
            lstGems.SelectedIndex = lstGems.Items.Count - 1;
        }

        private void lstGems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGems.SelectedItem == null)
                return;

            SpellItemEnchantmentEntry spellItemEnchant = (SpellItemEnchantmentEntry)lstGems.SelectedItem;

            txtEnchantName.Text = spellItemEnchant.SRefName;
            txtEnchantEntry.Text = spellItemEnchant.Id.ToString();
            txtMinStatEnchant1.Text = spellItemEnchant.MinAmount1.ToString();
            txtMinStatEnchant2.Text = spellItemEnchant.MinAmount2.ToString();
            txtMinStatEnchant3.Text = spellItemEnchant.MinAmount3.ToString();
            txtMaxStatEnchant1.Text = spellItemEnchant.MaxAmount1.ToString();
            txtMaxStatEnchant2.Text = spellItemEnchant.MaxAmount2.ToString();
            txtMaxStatEnchant3.Text = spellItemEnchant.MaxAmount3.ToString();

            txtEffect1.Text = spellItemEnchant.ObjectId1.ToString();
            txtEffect2.Text = spellItemEnchant.ObjectId2.ToString();
            txtEffect3.Text = spellItemEnchant.ObjectId3.ToString();

            txtRequiredLevel.Text = spellItemEnchant.requiredLevel.ToString();
        }

        private void btnSaveEnchant_Click(object sender, EventArgs e)
        {
            SpellItemEnchantmentEntry spellItemEcht = (SpellItemEnchantmentEntry)lstGems.Items[lstGems.SelectedIndex];
            spellItemEcht.SRefName = txtEnchantName.Text;
            spellItemEcht.MinAmount1 = Misc.ParseToUInt(txtMinStatEnchant1.Text);
            spellItemEcht.MinAmount2 = Misc.ParseToUInt(txtMinStatEnchant2.Text);
            spellItemEcht.MinAmount3 = Misc.ParseToUInt(txtMinStatEnchant3.Text);
            spellItemEcht.MaxAmount1 = Misc.ParseToUInt(txtMaxStatEnchant1.Text);
            spellItemEcht.MaxAmount2 = Misc.ParseToUInt(txtMaxStatEnchant2.Text);
            spellItemEcht.MaxAmount3 = Misc.ParseToUInt(txtMaxStatEnchant3.Text);
            spellItemEcht.ObjectId1 = Misc.ParseToUInt(txtEffect1.Text);
            spellItemEcht.ObjectId2 = Misc.ParseToUInt(txtEffect2.Text);
            spellItemEcht.ObjectId3 = Misc.ParseToUInt(txtEffect3.Text);
            spellItemEcht.requiredLevel = Misc.ParseToUInt(txtRequiredLevel.Text);
            try
            {
                DBCStores.SaveGemsEditorFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde des fichiers DBCs : " + ex.Message);
            }
        }

        private void btnDelEnchant_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enchantement ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            if (choix == System.Windows.Forms.DialogResult.OK)
            {
                if (lstGems.SelectedItem == null)
                    return;
                SpellItemEnchantmentEntry spellItemEnchant = (SpellItemEnchantmentEntry)lstGems.SelectedItem;
                DBCStores.SpellItemEnchantment.RemoveEntry(spellItemEnchant.Id);

                lstGems.Items.Remove(spellItemEnchant);
            }
            lstGems.SelectedIndex = lstGems.Items.Count - 1;
        }

        private void btnNewEnchant_Click(object sender, EventArgs e)
        {
            try
            {
                SpellItemEnchantmentEntry sie = new SpellItemEnchantmentEntry
                {
                    Id = DBCStores.SpellItemEnchantment.MaxKey + 1,
                    Charges = 0,
                    SpellDispelType1 = 0,
                    SpellDispelType2 = 0,
                    SpellDispelType3 = 0,
                    MinAmount1 = 0,
                    MinAmount2 = 0,
                    MinAmount3 = 0,
                    MaxAmount1 = 0,
                    MaxAmount2 = 0,
                    MaxAmount3 = 0,
                    ObjectId1 = 0,
                    ObjectId2 = 0,
                    ObjectId3 = 0,
                    SRefName = Loc.GetString("NewEnchant"),
                    ItemVisuals = 0,
                    Flags = 0,
                    ItemCache = 0,
                    SpellItemEnchantmentCondition = 0,
                    SkillLine = 0,
                    Skilllevel = 0,
                    requiredLevel = 0
                };
                lstGems.Items.Add(sie);
                DBCStores.SpellItemEnchantment.AddEntry(sie.Id, sie);
                lstGems.SelectedItem = sie;

                GemPropertiesEntry gpe = new GemPropertiesEntry
                {
                    Id = DBCStores.GemProperties.MaxKey + 1,
                    iRefID_SpellItemEnchantment = sie.Id,
                    MaxcountInv = 0,
                    MaxcountItem = 0,
                    Type = 0x01
                };
            }
            catch(Exception error)
            {
                MessageBox.Show(Loc.GetString("AddEnchantError") + "\n" + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchEnchant_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEffect1Mask_Click(object sender, EventArgs e)
        {
            ListDialog d = new ListDialog(typeof(EnchantStatsFlags), Misc.ParseToUInt(txtEffect1.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtEffect1.Text = d.Bitmask.ToString();
        }

        private void btnEffect2Mask_Click(object sender, EventArgs e)
        {
            ListDialog d = new ListDialog(typeof(EnchantStatsFlags), Misc.ParseToUInt(txtEffect2.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtEffect2.Text = d.Bitmask.ToString();
        }

        private void btnEffect3Mask_Click(object sender, EventArgs e)
        {
            ListDialog d = new ListDialog(typeof(EnchantStatsFlags), Misc.ParseToUInt(txtEffect3.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtEffect3.Text = d.Bitmask.ToString();
        }
    }
}
