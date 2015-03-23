using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;
using MDS.cBlp2;
using World_Editor.Stormlib;
using DBCLib.Structures335;

namespace World_Editor.Dialogs
{
    public partial class SpellIconDialog : Form
    {
        public uint choosenIcon { get; private set; }

        public SpellIconDialog(uint icon)
        {
            InitializeComponent();
            this.choosenIcon = icon;
        }

        private void SpellIconDialog_Load(object sender, EventArgs e)
        {
            DBCStores.SpellIcon.LoadData();

            listIcons.DisplayMember = "ToStringIdNameFile";
            listIcons.Items.AddRange(DBCStores.SpellIcon.Records.ToArray());

            if (DBCStores.SpellIcon.ContainsKey(choosenIcon))
                listIcons.SelectedItem = DBCStores.SpellIcon[choosenIcon];
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listIcons.Items.Clear();

            if (txtFilter.Text == "")
                listIcons.Items.AddRange(DBCStores.SpellIcon.Records.ToArray());
            else
                listIcons.Items.AddRange(DBCStores.SpellIcon.Records.Where(i => i.IconPath.ToLower().Contains(txtFilter.Text.ToLower())).ToArray());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (listIcons.SelectedItems == null)
                return;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void listIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listIcons.SelectedItem == null)
                return;

            SpellIconEntry i = (SpellIconEntry) listIcons.SelectedItem;
            txtPath.Text = i.IconPath + ".blp";

            choosenIcon = i.Id;

            if (MPQFile.Exists(i.IconPath + ".blp"))
                pbIcon.Image = Blp2.FromStream(new MPQFile(i.IconPath + ".blp"));
            else
                pbIcon.Image = Blp2.FromStream(new MPQFile("Interface\\InventoryItems\\WoWUnknownItem01.blp"));
        }
    }
}
