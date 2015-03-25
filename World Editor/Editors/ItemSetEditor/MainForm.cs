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
using World_Editor.Editors;

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
    }
}
