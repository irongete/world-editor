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

namespace World_Editor.GemsEditor
{
    public partial class MainForm : EditorForm
    {
        public static MainForm m_gemsEditor;
        ResourceManager Loc = new ResourceManager("World_Editor.Editors.GemsEditor.GemsEditorLocal", System.Reflection.Assembly.GetExecutingAssembly());

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
        }
    }
}
