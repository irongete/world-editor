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
    public partial class FactionGroupsMask : Form
    {
        public uint BitMask { get; private set; }

        public FactionGroupsMask(uint bitMask)
        {
            InitializeComponent();
            this.BitMask = bitMask;
        }

        private void FactionGroupsMask_Load(object sender, EventArgs e)
        {
            listGroups.Items.Clear();

            foreach (FactionGroupEntry f in DBCStores.FactionGroup.Records)
            {
                listGroups.Items.Add(f);

                int mask = (int)Math.Pow(2, (double)f.MaskId);

                if ((BitMask & mask) == mask)
                    listGroups.SetItemChecked(listGroups.Items.Count - 1, true);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            BitMask = 0;

            foreach (FactionGroupEntry f in listGroups.CheckedItems)
                BitMask |= (uint)Math.Pow(2, (double)f.MaskId);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
