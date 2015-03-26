using DBCLib.Structures335;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Editor.DBC;
using World_Editor.Dialogs;
using World_Editor.Editors;
using World_Editor.Editors.ProfessionEditor;

namespace World_Editor.ItemSetEditor
{
    public partial class MainForm : EditorForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadItemSetEditorFiles();
            }
            catch (Exception editor)
            {
                MessageBox.Show("LoadDbcError : " + editor);
                this.Close();
            }

            foreach (ItemSetEntry entry in DBCStores.ItemSet.Records)
            {
                lstItemSet.Items.Add(entry);
            }
            lstItemSet.SelectedIndex = lstItemSet.Items.Count - 1;
        }

        private void lstItemSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItemSet.SelectedItem == null)
                return;

            ItemSetEntry itemSetSelected = (ItemSetEntry)lstItemSet.SelectedItem;

            txtItem1.Text = itemSetSelected.items[0].ToString();
            txtItem2.Text = itemSetSelected.items[1].ToString();
            txtItem3.Text = itemSetSelected.items[2].ToString();
            txtItem4.Text = itemSetSelected.items[3].ToString();
            txtItem5.Text = itemSetSelected.items[4].ToString();
            txtItem6.Text = itemSetSelected.items[5].ToString();
            txtItem7.Text = itemSetSelected.items[6].ToString();
            txtItem8.Text = itemSetSelected.items[7].ToString();

            txtEffect1.Text = itemSetSelected.spells[0].ToString();
            txtEffect2.Text = itemSetSelected.spells[1].ToString();
            txtEffect3.Text = itemSetSelected.spells[2].ToString();
            txtEffect4.Text = itemSetSelected.spells[3].ToString();
            txtEffect5.Text = itemSetSelected.spells[4].ToString();
            txtEffect6.Text = itemSetSelected.spells[5].ToString();
            txtEffect7.Text = itemSetSelected.spells[6].ToString();
            txtEffect8.Text = itemSetSelected.spells[7].ToString();

            txtNbItemForEffect1.Text = itemSetSelected.nbItemSpells[0].ToString();
            txtNbItemForEffect2.Text = itemSetSelected.nbItemSpells[1].ToString();
            txtNbItemForEffect3.Text = itemSetSelected.nbItemSpells[2].ToString();
            txtNbItemForEffect4.Text = itemSetSelected.nbItemSpells[3].ToString();
            txtNbItemForEffect5.Text = itemSetSelected.nbItemSpells[4].ToString();
            txtNbItemForEffect6.Text = itemSetSelected.nbItemSpells[5].ToString();
            txtNbItemForEffect7.Text = itemSetSelected.nbItemSpells[6].ToString();
            txtNbItemForEffect8.Text = itemSetSelected.nbItemSpells[7].ToString();
        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtItem1.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtItem1.Text = s.choosenItem.ToString();
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtItem2.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtItem2.Text = s.choosenItem.ToString();
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtItem3.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtItem3.Text = s.choosenItem.ToString();
        }

        private void btnItem4_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtItem4.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtItem4.Text = s.choosenItem.ToString();
        }

        private void btnItem5_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtItem5.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtItem5.Text = s.choosenItem.ToString();
        }

        private void btnItem6_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtItem6.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtItem6.Text = s.choosenItem.ToString();
        }

        private void btnItem7_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtItem7.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtItem7.Text = s.choosenItem.ToString();
        }

        private void btnItem8_Click(object sender, EventArgs e)
        {
            SearchComponent s = new SearchComponent(txtItem8.Text);
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtItem8.Text = s.choosenItem.ToString();
        }

        private void btnEffect1_Click(object sender, EventArgs e)
        {
            SpellDialog s = new SpellDialog(uint.Parse(txtEffect1.Text));
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtEffect1.Text = s.choosenSpell.ToString();
        }
    }
}
