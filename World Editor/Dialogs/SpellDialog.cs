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

namespace World_Editor.Dialogs
{
    public partial class SpellDialog : Form
    {
        public uint choosenSpell { get; set; }

        public SpellDialog(uint spellId)
        {
            InitializeComponent();
            this.choosenSpell = spellId;
        }

        private void SpellDialog_Load(object sender, EventArgs e)
        {
            DBCStores.Spell.LoadData();

            lstSpells.Items.AddRange(DBCStores.Spell.Records.ToArray());

            if (DBCStores.Spell.ContainsKey(choosenSpell))
                lstSpells.SelectedItem = DBCStores.Spell[choosenSpell];
        }

        private void btnValidateComponent_Click(object sender, EventArgs e)
        {
            if (lstSpells.SelectedItems == null)
                return;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchSpells_TextChanged(object sender, EventArgs e)
        {
            lstSpells.Items.Clear();

            if (txtSearchSpells.Text == "")
                lstSpells.Items.AddRange(DBCStores.Spell.Records.ToArray());
            else
                lstSpells.Items.AddRange(DBCStores.Spell.Records.Where(i => i.SpellName.String.ToLower().Contains(txtSearchSpells.Text.ToLower())).ToArray());
        }

        private void lstSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedItem == null)
                return;

            SpellEntry s = (SpellEntry)lstSpells.SelectedItem;
            //txtSpellId.Text = s.Id.ToString();

            choosenSpell = s.Id;
        }

    }
}
