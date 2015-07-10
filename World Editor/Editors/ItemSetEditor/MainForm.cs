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

            txtSetId.Text = itemSetSelected.Id.ToString();
            txtSetName.Text = itemSetSelected.sRefName;
            txtRequiredSkill.Text = itemSetSelected.RequiredSkill.ToString();
            txtRequiredSkillLevel.Text = itemSetSelected.RequiredLevelSkill.ToString();

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

        #region btnAddItem
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
        #endregion

        #region btnAddEffect
        private void btnEffect1_Click(object sender, EventArgs e)
        {
            SpellDialog s = new SpellDialog(uint.Parse(txtEffect1.Text));
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtEffect1.Text = s.choosenSpell.ToString();
        }

        private void btnEffect2_Click(object sender, EventArgs e)
        {
            SpellDialog s = new SpellDialog(uint.Parse(txtEffect2.Text));
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtEffect2.Text = s.choosenSpell.ToString();
        }

        private void btnEffect3_Click(object sender, EventArgs e)
        {
            SpellDialog s = new SpellDialog(uint.Parse(txtEffect3.Text));
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtEffect3.Text = s.choosenSpell.ToString();
        }

        private void btnEffect4_Click(object sender, EventArgs e)
        {
            SpellDialog s = new SpellDialog(uint.Parse(txtEffect4.Text));
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtEffect4.Text = s.choosenSpell.ToString();
        }

        private void btnEffect5_Click(object sender, EventArgs e)
        {
            SpellDialog s = new SpellDialog(uint.Parse(txtEffect5.Text));
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtEffect5.Text = s.choosenSpell.ToString();
        }

        private void btnEffect6_Click(object sender, EventArgs e)
        {
            SpellDialog s = new SpellDialog(uint.Parse(txtEffect6.Text));
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtEffect6.Text = s.choosenSpell.ToString();
        }

        private void btnEffect7_Click(object sender, EventArgs e)
        {
            SpellDialog s = new SpellDialog(uint.Parse(txtEffect7.Text));
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtEffect7.Text = s.choosenSpell.ToString();
        }

        private void btnEffect8_Click(object sender, EventArgs e)
        {
            SpellDialog s = new SpellDialog(uint.Parse(txtEffect8.Text));
            s.ShowDialog();
            if (s.DialogResult == DialogResult.OK)
                txtEffect8.Text = s.choosenSpell.ToString();
        }
        #endregion

        private void btnNewItemSet_Click(object sender, EventArgs e)
        {

            uint[] itemsId = new uint[8];
            uint[] spellsId = new uint[8];
            uint[] nbItemSpellsCount = new uint[8];

            try
            {
                ItemSetEntry t = new ItemSetEntry
                {
                    Id = DBCStores.ItemSet.MaxKey + 1,
                    sRefName = "New set",
                    items = itemsId,
                    spells = spellsId,
                    nbItemSpells = nbItemSpellsCount,
                    RequiredSkill = uint.Parse(txtRequiredSkill.Text),
                    RequiredLevelSkill = uint.Parse(txtRequiredSkillLevel.Text)
                };

                lstItemSet.Items.Add(t);
                DBCStores.ItemSet.AddEntry(t.Id, t);

                lstItemSet.SelectedIndex = lstItemSet.Items.Count - 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Add ItemSet Error");
            }
        }

        private void btnDelItemSet_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce set d'items ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            if (choix == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

                    --lstItemSet.SelectedIndex;

                    DBCStores.ItemSet.RemoveEntry(t.Id);
                    lstItemSet.Items.Remove(t);
                }
                catch (Exception)
                {
                    MessageBox.Show("Del ItemSet Error");
                }
            }
        }

        private void btnSaveItemSet_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveItemSetEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show("Save Dbc Error");
            }
        }

        #region textChanged

        private void txtSetName_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtSetName.Text.Equals(""))
                t.sRefName = txtSetName.Text;

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtRequiredSkill_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtRequiredSkill.Text.Equals(""))
                t.RequiredSkill = uint.Parse(txtRequiredSkill.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtRequiredSkillLevel_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtRequiredSkillLevel.Text.Equals(""))
                t.RequiredLevelSkill = uint.Parse(txtRequiredSkillLevel.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtItem1_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtItem1.Text.Equals(""))
                t.items[0] = uint.Parse(txtItem1.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtItem2_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtItem2.Text.Equals(""))
                t.items[1] = uint.Parse(txtItem2.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtItem3_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtItem3.Text.Equals(""))
                t.items[2] = uint.Parse(txtItem3.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtItem4_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtItem4.Text.Equals(""))
                t.items[3] = uint.Parse(txtItem4.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtItem5_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtItem5.Text.Equals(""))
                t.items[4] = uint.Parse(txtItem5.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtItem6_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtItem6.Text.Equals(""))
                t.items[5] = uint.Parse(txtItem6.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtItem7_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtItem7.Text.Equals(""))
                t.items[6] = uint.Parse(txtItem7.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtItem8_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtItem8.Text.Equals(""))
                t.items[7] = uint.Parse(txtItem8.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtEffect1_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtEffect1.Text.Equals(""))
                t.spells[0] = uint.Parse(txtEffect1.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtNbItemForEffect1_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtNbItemForEffect1.Text.Equals(""))
                t.nbItemSpells[0] = uint.Parse(txtNbItemForEffect1.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtEffect2_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtEffect2.Text.Equals(""))
                t.spells[1] = uint.Parse(txtEffect2.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtNbItemForEffect2_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtNbItemForEffect2.Text.Equals(""))
                t.nbItemSpells[1] = uint.Parse(txtNbItemForEffect2.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtEffect3_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtEffect3.Text.Equals(""))
                t.spells[2] = uint.Parse(txtEffect3.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtNbItemForEffect3_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtNbItemForEffect3.Text.Equals(""))
                t.nbItemSpells[2] = uint.Parse(txtNbItemForEffect3.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtEffect4_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtEffect4.Text.Equals(""))
                t.spells[3] = uint.Parse(txtEffect4.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtNbItemForEffect4_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtNbItemForEffect4.Text.Equals(""))
                t.nbItemSpells[3] = uint.Parse(txtNbItemForEffect4.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtEffect5_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtEffect5.Text.Equals(""))
                t.spells[4] = uint.Parse(txtEffect5.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtNbItemForEffect5_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtNbItemForEffect5.Text.Equals(""))
                t.nbItemSpells[4] = uint.Parse(txtNbItemForEffect5.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtEffect6_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtEffect6.Text.Equals(""))
                t.spells[5] = uint.Parse(txtEffect6.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtNbItemForEffect6_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtNbItemForEffect6.Text.Equals(""))
                t.nbItemSpells[5] = uint.Parse(txtNbItemForEffect6.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtEffect7_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtEffect7.Text.Equals(""))
                t.spells[6] = uint.Parse(txtEffect7.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtNbItemForEffect7_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtNbItemForEffect7.Text.Equals(""))
                t.nbItemSpells[6] = uint.Parse(txtNbItemForEffect7.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtEffect8_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtEffect8.Text.Equals(""))
                t.spells[7] = uint.Parse(txtEffect8.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        private void txtNbItemForEffect8_TextChanged(object sender, EventArgs e)
        {
            ItemSetEntry t = (ItemSetEntry)lstItemSet.Items[lstItemSet.SelectedIndex];

            if (!txtNbItemForEffect8.Text.Equals(""))
                t.nbItemSpells[7] = uint.Parse(txtNbItemForEffect8.Text);

            DBCStores.ItemSet.ReplaceEntry(t.Id, t);
            lstItemSet.Items[lstItemSet.SelectedIndex] = t;
        }

        #endregion
    }
}
