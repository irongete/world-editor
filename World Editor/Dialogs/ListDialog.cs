using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Editor.Dialogs
{
    public partial class ListDialog : Form
    {
        public int Bitmask { get; set; }

        /*
         * Pour fonctioner, l'enum devra être sous cette forme :
         * enum NomEnum 
         * {
         *      ITEM_1  =   1,
         *      ITEM_2  =   2,
         *      ITEM_3  =   3,
         *      ITEM_4  =   4,
         *      etc...
         * };
         */
        public Type type { get; set; }

        public ListDialog(Type flagType, uint loaded_bitmask = 0)
        {
            InitializeComponent();
            Bitmask = (int)loaded_bitmask;
            type = flagType;
        }

        private void ListDialog_Load(object sender, EventArgs e)
        {
            lstItems.Items.Clear();

            foreach (string f in Enum.GetNames(type))
            {
                lstItems.Items.Add(f);

                int mask = (int)Enum.Parse(type, f);

                if (((int)Bitmask & mask) == mask)
                    lstItems.SelectedIndex = lstItems.Items.Count - 1;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Bitmask = 0;
            Bitmask = (int)Enum.Parse(type, lstItems.SelectedItem.ToString());

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
