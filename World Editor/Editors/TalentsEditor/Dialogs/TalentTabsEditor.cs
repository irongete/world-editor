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

namespace World_Editor.TalentsEditor.Dialogs
{
    public partial class TalentTabsEditor : Form
    {
        public TalentTabsEditor()
        {
            InitializeComponent();
        }

        private void TalentTabsEditor_Load(object sender, EventArgs e)
        {
            listTalentTab.Items.Clear();
            listTalentTab.Items.AddRange(DBCStores.TalentTab.Records.ToArray());
            listTalentTab.SelectedIndex = 0;
        }

        private void listTalentTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTalentTab.SelectedItem == null)
                return;

            TalentTabEntry t = (TalentTabEntry)listTalentTab.SelectedItem;
            txtId.Text = t.Id.ToString();
            listOrder.SelectedIndex = (int)t.TabPage;
            txtIcon.Text = t.SpellIcon.ToString();
            txtInternalName.Text = t.InternalName;
            txtName.Text = t.Name;
            txtRaces.Text = t.RaceMask.ToString();
            txtClasses.Text = t.ClassMask.ToString();
            txtPets.Text = t.PetTalentMask.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TalentTabEntry t = new TalentTabEntry
            {
                Id = DBCStores.TalentTab.MaxKey + 1,
                Name = "Nouvel arbre de talents",
                InternalName = "NewTalentTree",
            };

            DBCStores.TalentTab.AddEntry(t.Id, t);
            listTalentTab.Items.Add(t);
            listTalentTab.SelectedIndex = listTalentTab.Items.Count - 1;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            TalentTabEntry tb = (TalentTabEntry)listTalentTab.SelectedItem;

            foreach (TalentEntry t in DBCStores.Talent.Records.Where(th => th.TabId == tb.Id))
                DBCStores.Talent.RemoveEntry(t.Id);

            listTalentTab.SelectedIndex = 0;

            listTalentTab.Items.Remove(tb);
            DBCStores.TalentTab.RemoveEntry(tb.Id);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private uint ParseToUInt(string value)
        {
            uint tmp;
            UInt32.TryParse(value, out tmp);
            return tmp;
        }

        private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTalentTab.SelectedItem == null)
                return;

            TalentTabEntry t = (TalentTabEntry)listTalentTab.SelectedItem;
            t.TabPage = (uint)listOrder.SelectedIndex;
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {

        }

        private void btnRaces_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskRaces d = new World_Editor.Dialogs.MaskRaces();
            d.MaskRacesValue = ParseToUInt(txtRaces.Text);
            d.ShowDialog();
            txtRaces.Text = d.MaskRacesValue.ToString();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            World_Editor.Dialogs.MaskClasses d = new World_Editor.Dialogs.MaskClasses();
            d.MaskClassesValue = ParseToUInt(txtClasses.Text);
            d.ShowDialog();
            txtClasses.Text = d.MaskClassesValue.ToString();
        }

        private void btnPets_Click(object sender, EventArgs e)
        {

        }

        private void txtIcon_TextChanged(object sender, EventArgs e)
        {
            if (listTalentTab.SelectedItem == null)
                return;

            TalentTabEntry t = (TalentTabEntry)listTalentTab.SelectedItem;
            t.SpellIcon = ParseToUInt(txtIcon.Text);
        }

        private void txtInternalName_TextChanged(object sender, EventArgs e)
        {
            if (listTalentTab.SelectedItem == null)
                return;

            TalentTabEntry t = (TalentTabEntry)listTalentTab.SelectedItem;
            t.InternalName = txtInternalName.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (listTalentTab.SelectedItem == null)
                return;

            TalentTabEntry t = (TalentTabEntry)listTalentTab.SelectedItem;
            t.Name = txtName.Text;
            listTalentTab.SelectedItem = t;
        }

        private void txtRaces_TextChanged(object sender, EventArgs e)
        {
            if (listTalentTab.SelectedItem == null)
                return;

            TalentTabEntry t = (TalentTabEntry)listTalentTab.SelectedItem;
            t.RaceMask = ParseToUInt(txtRaces.Text);
        }

        private void txtClasses_TextChanged(object sender, EventArgs e)
        {
            if (listTalentTab.SelectedItem == null)
                return;

            TalentTabEntry t = (TalentTabEntry)listTalentTab.SelectedItem;
            t.ClassMask = ParseToUInt(txtClasses.Text);
        }

        private void txtPets_TextChanged(object sender, EventArgs e)
        {
            if (listTalentTab.SelectedItem == null)
                return;

            TalentTabEntry t = (TalentTabEntry)listTalentTab.SelectedItem;
            t.PetTalentMask = ParseToUInt(txtPets.Text);
        }
    }
}
