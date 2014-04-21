using DBCLib.Structures335;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;

namespace World_Editor.NamesReservedEditor
{
    public partial class MainForm : Form
    {
        ResourceManager Loc = new ResourceManager("World_Editor.Editors.NamesReservedEditor.NamesReservedEditorLocal", System.Reflection.Assembly.GetExecutingAssembly());
        public MainForm()
        {
            InitializeComponent();
        }

        public static NamesReservedEditor.MainForm m_namesReservedEditor;
        public static NamesReservedEditor.MainForm GetChildInstance()
        {
            if (m_namesReservedEditor == null)
                m_namesReservedEditor = new MainForm();

            return m_namesReservedEditor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadNamesReservedFiles();
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("LoadDbcError"));
                this.Close();
            }

            lstNamesReserved.Items.Clear();
            lstNicknamesReserved.Items.Clear();
            foreach (NamesReservedEntry entry in DBC.DBCStores.NamesReserved.Records)
                lstNamesReserved.Items.Add(entry);

            foreach (NamesProfanityEntry entry in DBC.DBCStores.NamesProfanity.Records)
                lstNicknamesReserved.Items.Add(entry);

            lstNamesReserved.SelectedIndex = 0;
            lstNicknamesReserved.SelectedIndex = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_namesReservedEditor = null;
        }

        private void lstNamesReserved_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNamesReserved.SelectedIndex == -1)
                return;

            NamesReservedEntry t = (NamesReservedEntry)lstNamesReserved.Items[lstNamesReserved.SelectedIndex];

            txt_id.Text = t.Id.ToString();
            txt_nom.Text = t.Name.ToString();
        }

        private void lstNicknamesReserved_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNicknamesReserved.SelectedIndex == -1)
                return;

            NamesProfanityEntry n = (NamesProfanityEntry)lstNicknamesReserved.Items[lstNicknamesReserved.SelectedIndex];

            txt_idNickname.Text = n.Id.ToString();
            txt_nomNickname.Text = n.Name.ToString();
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            try
            {
                NamesReservedEntry t = new NamesReservedEntry
                {
                    Id = DBCStores.NamesReserved.MaxKey + 1,
                    Name = Loc.GetString("NewNameReserved"),
                    LanguageId = 2,
                };

                lstNamesReserved.Items.Add(t);
                DBCStores.NamesReserved.AddEntry(t.Id, t);

                lstNamesReserved.SelectedIndex = lstNamesReserved.Items.Count - 1;
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("AddNameReservedError"));
            }
        }

        private void btn_ajouterNickname_Click(object sender, EventArgs e)
        {
            try
            {
                NamesProfanityEntry t = new NamesProfanityEntry
                {
                    Id = DBCStores.NamesProfanity.MaxKey + 1,
                    Name = Loc.GetString("NewNameReserved"),
                    LanguageId = 2,
                };

                lstNicknamesReserved.Items.Add(t);
                DBCStores.NamesProfanity.AddEntry(t.Id, t);

                lstNicknamesReserved.SelectedIndex = lstNicknamesReserved.Items.Count - 1;
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("AddNameReservedError"));
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveNamesReservedEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("SaveDbcError"));
            }
        }

        private void btn_enregistrerNickname_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveNamesReservedEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("SaveDbcError"));
            }
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            NamesReservedEntry t = (NamesReservedEntry)lstNamesReserved.Items[lstNamesReserved.SelectedIndex];

            t.Name = txt_nom.Text;

            DBCStores.NamesReserved.ReplaceEntry(t.Id, t);
            lstNamesReserved.Items[lstNamesReserved.SelectedIndex] = t;
        }

        private void txt_nomNickname_TextChanged(object sender, EventArgs e)
        {
            NamesProfanityEntry t = (NamesProfanityEntry)lstNicknamesReserved.Items[lstNicknamesReserved.SelectedIndex];

            t.Name = txt_nomNickname.Text;

            DBCStores.NamesProfanity.ReplaceEntry(t.Id, t);
            lstNicknamesReserved.Items[lstNicknamesReserved.SelectedIndex] = t;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce nom ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            if (choix == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    NamesReservedEntry t = (NamesReservedEntry)lstNamesReserved.Items[lstNamesReserved.SelectedIndex];

                    --lstNamesReserved.SelectedIndex;

                    DBCStores.NamesReserved.RemoveEntry(t.Id);
                    lstNamesReserved.Items.Remove(t);
                }
                catch (Exception)
                {
                    MessageBox.Show(Loc.GetString("DelTitleError"));
                }
            }
        }

        private void btn_deleteNickname_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce nom ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            if (choix == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    NamesProfanityEntry t = (NamesProfanityEntry)lstNicknamesReserved.Items[lstNicknamesReserved.SelectedIndex];

                    --lstNicknamesReserved.SelectedIndex;

                    DBCStores.NamesProfanity.RemoveEntry(t.Id);
                    lstNicknamesReserved.Items.Remove(t);
                }
                catch (Exception)
                {
                    MessageBox.Show(Loc.GetString("DelTitleError"));
                }
            }
        }
    }
}
