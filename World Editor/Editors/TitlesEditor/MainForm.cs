using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using DBCLib.Structures335;
using World_Editor.DBC;

namespace World_Editor.TitlesEditor
{
    public partial class MainForm : Form
    {
        ResourceManager Loc = new ResourceManager("World_Editor.Editors.TitlesEditor.TitlesEditorLocal", System.Reflection.Assembly.GetExecutingAssembly());
        public MainForm()
        {
            InitializeComponent();
        }

        public static TitlesEditor.MainForm m_titlesEditor;
        public static TitlesEditor.MainForm GetChildInstance()
        {
            if (m_titlesEditor == null)
                m_titlesEditor = new MainForm();

            return m_titlesEditor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadTitlesEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("LoadDbcError"));
                this.Close();
            }

            listTitles.Items.Clear();
            foreach (CharTitlesEntry t in DBCStores.CharTitles.Records)
                listTitles.Items.Add(t);

            listTitles.SelectedIndex = 0;
        }

        private void listTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTitles.SelectedIndex == -1)
                return;

            CharTitlesEntry t = (CharTitlesEntry)listTitles.Items[listTitles.SelectedIndex];

            txtID.Text = t.Id.ToString();
            txtID2.Text = t.TitleMaskId.ToString();
            txtNameMale.Text = t.NameMale;
            txtNameFemale.Text = t.NameFemale;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CharTitlesEntry t = new CharTitlesEntry
                {
                    Id = DBCStores.CharTitles.MaxKey + 1,
                    ConditionId = 0,
                    NameMale = Loc.GetString("NewTitle"),
                    NameFemale = Loc.GetString("NewTitle"),
                    TitleMaskId = DBCStores.CharTitles.Records.Max(ti => ti.TitleMaskId) + 1,
                };

                listTitles.Items.Add(t);
                DBCStores.CharTitles.AddEntry(t.Id, t);

                listTitles.SelectedIndex = listTitles.Items.Count - 1;
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("AddTitleError"));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce titre ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            if(choix == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    CharTitlesEntry t = (CharTitlesEntry)listTitles.Items[listTitles.SelectedIndex];

                    --listTitles.SelectedIndex;

                    DBCStores.CharTitles.RemoveEntry(t.Id);
                    listTitles.Items.Remove(t);
                }
                catch (Exception)
                {
                    MessageBox.Show(Loc.GetString("DelTitleError"));
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveTitlesEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("SaveDbcError"));
            }
        }

        private void txtNameMale_TextChanged(object sender, EventArgs e)
        {
            CharTitlesEntry t = (CharTitlesEntry)listTitles.Items[listTitles.SelectedIndex];

            t.NameMale = txtNameMale.Text;

            DBCStores.CharTitles.ReplaceEntry(t.Id, t);
            listTitles.Items[listTitles.SelectedIndex] = t;
        }

        private void txtNameFemale_TextChanged(object sender, EventArgs e)
        {
            CharTitlesEntry t = (CharTitlesEntry)listTitles.Items[listTitles.SelectedIndex];

            t.NameFemale = txtNameFemale.Text;

            DBCStores.CharTitles.ReplaceEntry(t.Id, t);
            listTitles.Items[listTitles.SelectedIndex] = t;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_titlesEditor = null;
        }
    }
}
