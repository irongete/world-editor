using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World_Editor.Dialogs
{
    public partial class FlagDialog : Form
    {
        public int Bitmask { get; set; }

        /*
         * Pour fonctioner, l'enum devra être sous cette forme :
         * enum NomEnum 
         * {
         *      FLAG_1  =   1,
         *      FLAG_2  =   2,
         *      FLAG_3  =   4,
         *      FLAG_4  =   8,
         *      etc...
         * };
         */
        public Type type { get; set; }

        public FlagDialog(Type flagType, uint loaded_bitmask = 0)
        {
            InitializeComponent();
            Bitmask = (int)loaded_bitmask;
            type = flagType;
        }

        private void FlagDialog_Load(object sender, EventArgs e)
        {
            lstFlags.Items.Clear();

            foreach (string f in Enum.GetNames(type))
            {
                lstFlags.Items.Add(f);

                int mask = (int)Enum.Parse(type, f);

                if (((int)Bitmask & mask) == mask)
                    lstFlags.SetItemChecked(lstFlags.Items.Count - 1, true);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Bitmask = 0;

            foreach (string f in lstFlags.CheckedItems)
                Bitmask |= (int)Enum.Parse(type, f);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
