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
    public partial class MaskRaces : Form
    {
        public uint MaskRacesValue { get; set; }

        public MaskRaces()
        {
            InitializeComponent();
        }

        private void MaskRaces_Load(object sender, EventArgs e)
        {
            listRaces.Items.Clear();

            foreach (ChrRacesEntry r in DBCStores.ChrRaces.Records)
            {
                listRaces.Items.Add(r);
                int maskRace = (int)Math.Pow(2, (double)(r.RaceId - 1));

                if (((int)MaskRacesValue & maskRace) == maskRace)
                    listRaces.SetItemChecked(listRaces.Items.Count - 1, true);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MaskRacesValue = 0;

            foreach (ChrRacesEntry r in listRaces.CheckedItems)
                MaskRacesValue |= (uint)Math.Pow(2, (double)(r.RaceId - 1));

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
