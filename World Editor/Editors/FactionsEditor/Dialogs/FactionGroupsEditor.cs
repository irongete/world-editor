using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBCLib.Structures335;
using World_Editor.DBC;

namespace World_Editor.FactionsEditor.Dialogs
{
    public partial class FactionGroupsEditor : Form
    {
        public FactionGroupsEditor()
        {
            InitializeComponent();
        }

        private void FactionGroupsEditor_Load(object sender, EventArgs e)
        {
            listGroups.Items.Clear();

            foreach (FactionGroupEntry f in DBCStores.FactionGroup.Records)
                listGroups.Items.Add(f);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FactionGroupEntry f = new FactionGroupEntry
            {
                Id = DBCStores.FactionGroup.MaxKey + 1,
                MaskId = DBCStores.FactionGroup.Records.Max(fg => fg.MaskId) + 1,
                InternalName = "NewGroup",
                Name = "Nouveau groupe",
            };

            listGroups.Items.Add(f);
            DBCStores.FactionGroup.AddEntry(f.Id, f);

            listGroups.SelectedIndex = listGroups.Items.Count - 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            FactionGroupEntry f = (FactionGroupEntry)listGroups.Items[listGroups.SelectedIndex];

            --listGroups.SelectedIndex;

            listGroups.Items.Remove(f);
            DBCStores.FactionGroup.RemoveEntry(f.Id);
        }

        private void listGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGroups.SelectedIndex == -1)
                return;

            FactionGroupEntry f = (FactionGroupEntry)listGroups.Items[listGroups.SelectedIndex];

            txtId.Text = f.Id.ToString();
            txtMaskId.Text = f.MaskId.ToString();
            txtInternalName.Text = f.InternalName;
            txtName.Text = f.Name;
        }

        private void txtInternalName_TextChanged(object sender, EventArgs e)
        {
            FactionGroupEntry f = (FactionGroupEntry)listGroups.Items[listGroups.SelectedIndex];

            f.InternalName = txtInternalName.Text;

            DBCStores.FactionGroup.ReplaceEntry(f.Id, f);
            listGroups.Items[listGroups.SelectedIndex] = f;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            FactionGroupEntry f = (FactionGroupEntry)listGroups.Items[listGroups.SelectedIndex];

            f.Name = txtName.Text;

            DBCStores.FactionGroup.ReplaceEntry(f.Id, f);
            listGroups.Items[listGroups.SelectedIndex] = f;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
