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

            lstSpells.DisplayMember = "ToStringIdNameFile";
            lstSpells.Items.AddRange(DBCStores.Spell.Records.ToArray());

            if (DBCStores.Spell.ContainsKey(choosenSpell))
                lstSpells.SelectedItem = DBCStores.Spell[choosenSpell];
        }

    }
}
