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

namespace World_Editor.Dialogs
{
    public partial class MaskClasses : Form
    {
        public uint MaskClassesValue { get; set; }

        public MaskClasses()
        {
            InitializeComponent();
        }

        private void MaskClasses_Load(object sender, EventArgs e)
        {
            listClasses.Items.Clear();

            foreach (ChrClassesEntry c in DBCStores.ChrClasses.Records)
            {
                listClasses.Items.Add(c);
                int maskRace = (int)Math.Pow(2, (double)(c.ClassId - 1));

                if (((int)MaskClassesValue & maskRace) == maskRace)
                    listClasses.SetItemChecked(listClasses.Items.Count - 1, true);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MaskClassesValue = 0;

            foreach (ChrClassesEntry c in listClasses.CheckedItems)
                MaskClassesValue |= (uint)Math.Pow(2, (double)(c.ClassId - 1));

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
