using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBCLib.Structures335;
using World_Editor.Database;
using World_Editor.DBC;

namespace World_Editor.ItemDbcGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadItemDbcGeneratorFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des DBCs : " + ex.Message);
                return;
            }

            if (!Properties.Settings.Default.OptionUseDatabase)
            {
                btnGenerate.Enabled = false;
                MessageBox.Show("Impossible de générer un Item.dbc sans accès à la base de données.");
            }
            lblProgress.Text = "";
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                txtFrom.Enabled = false;
                txtTo.Enabled = false;
            }
            else
            {
                txtFrom.Enabled = true;
                txtTo.Enabled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // TODO : Rendre asynchrone le génération
            try
            {
                ItemTemplate[] items = checkAll.Checked ? ProjectManager.Connection.GetItemTemplate() : ProjectManager.Connection.GetItemTemplate(Misc.ParseToUInt(txtFrom.Text), Misc.ParseToUInt(txtTo.Text));

                // Si on veut créer un nouveau fichier, on commence par supprimer toutes les entrées.
                if (radioNew.Checked)
                    foreach (ItemEntry i in DBCStores.Item.Records.ToArray())
                        DBCStores.Item.RemoveEntry(i.Id);

                foreach (ItemTemplate it in items)
                {
                    ItemEntry i = new ItemEntry
                    {
                        Id = (uint)it.Entry,
                        Class = (uint)it.Class,
                        SubClass = (uint)it.SubClass,
                        SoundOverrideSubClassId = 0,
                        Material = it.Material,
                        Sheath = (uint)it.Sheath,
                        InventoryType = (uint)it.InventoryType,
                        DisplayId = (uint)it.DisplayId,
                    };

                    if (DBCStores.Item.ContainsKey(i.Id))
                        DBCStores.Item.RemoveEntry(i.Id);

                    DBCStores.Item.AddEntry(i.Id, i);
                }

                DBCStores.SaveItemDbcGeneratorFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération : " + ex.Message);
            }
        }
    }
}
