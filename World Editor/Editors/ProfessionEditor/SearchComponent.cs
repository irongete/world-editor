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
        public String choosenItem { get; private set; }
        char[] splitter = new char[] { ',' };
        public SearchComponent(String txtItemId)
        {
            InitializeComponent();
            this.choosenItem = txtItemId;
        }

        private void SearchComponent_Load(object sender, EventArgs e)
        {
            txtSearchComponents.Focus();
            if (choosenItem != "")
            {
                List<String> Items = new List<string>();
                Items = ProjectManager.SelectedProject.GetMysqlConnector().GetItemById(choosenItem.ToString());
                lstComponents.DataSource = Items;
            }
        }

        private void txtSearchComponents_TextChanged(object sender, EventArgs e)
        {
            List<String> Items = new List<string>();
            int v;
            if (Int32.TryParse(txtSearchComponents.Text.Trim(), out v))
            {
                Items = ProjectManager.SelectedProject.GetMysqlConnector().GetItemById(txtSearchComponents.Text);
            }
            else
            {
                Items = ProjectManager.SelectedProject.GetMysqlConnector().GetItemByName(txtSearchComponents.Text);
            }
            lstComponents.DataSource = Items;
        }

        private void lstComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tabItems;
            tabItems = lstComponents.SelectedItem.ToString().Split(splitter);
            txtComponentID.Text = tabItems[0];
            choosenItem = txtComponentID.Text;
        }

        private void btnValidateComponent_Click(object sender, EventArgs e)
        {
            if (lstComponents.SelectedItems == null)
                return;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
