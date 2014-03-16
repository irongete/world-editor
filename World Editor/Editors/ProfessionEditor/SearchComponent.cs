using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World_Editor.Editors.ProfessionEditor
{
    public partial class SearchComponent : Form
    {
        TextBox txtItemId;
        char[] splitter = new char[] { ',' };
        public SearchComponent(TextBox txtItemId)
        {
            InitializeComponent();
            this.txtItemId = txtItemId;
        }

        private void SearchComponent_Load(object sender, EventArgs e)
        {
            txtSearchComponents.Focus();
            if (txtItemId.Text != "")
            {
                List<String> Items = new List<string>();
                Items = ProjectManager.Connection.GetItemById(txtItemId.Text);
                lstComponents.DataSource = Items;
            }
        }

        private void txtSearchComponents_TextChanged(object sender, EventArgs e)
        {
            List<String> Items = new List<string>();
            Items = ProjectManager.Connection.GetItemByName(txtSearchComponents.Text);
            lstComponents.DataSource = Items;
        }

        private void lstComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tabItems;
            tabItems = lstComponents.SelectedItem.ToString().Split(splitter);
            txtComponentID.Text = tabItems[0];
            txtItemId.Text = txtComponentID.Text;
        }

        private void btnValidateComponent_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtComponentID_TextChanged(object sender, EventArgs e)
        {
            List<String> Items = new List<string>();
            Items = ProjectManager.Connection.GetItemById(txtItemId.Text);
            lstComponents.DataSource = Items;
        }
    }
}
