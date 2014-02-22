using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DBCLib.Structures335;
using World_Editor.DBC;
using System.Resources;

namespace World_Editor.Editors.GameTipsEditor
{
    public partial class MainForm : Form
    {
        ResourceManager Loc = new ResourceManager("World_Editor.Editors.GameTipsEditor.GameTipsEditorLocal", System.Reflection.Assembly.GetExecutingAssembly());

        public MainForm()
        {
            InitializeComponent();
        }

        public static MainForm GameTipsEditor;
        public static MainForm GetChildInstance()
        {
            return GameTipsEditor ?? (GameTipsEditor = new MainForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadGameTipsEditorFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                Close();
            }

            listGameTips.Items.Clear();
            foreach (var g in DBCStores.GameTips.Records)
            {
                listGameTips.Items.Add(g);
            }

            if (listGameTips.Items.Count > 0)
                listGameTips.SelectedIndex = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameTipsEditor = null;
        }

        private void listGameTips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGameTips.SelectedIndex == -1)
                return;

            var t = (GameTipsEntry) listGameTips.SelectedItem;

            txtTip.Text = t.Tips;
        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {
            lblPreview.Clear();
            lblPreview.Text = FormatTip(txtTip.Text);
            
            foreach (var foo in _fooList)
            {
                lblPreview.SelectionStart = foo.BeginPosition;
                lblPreview.SelectionLength = foo.Lenght;
                lblPreview.SelectionColor =
                    Color.FromArgb(int.Parse(foo.Color, System.Globalization.NumberStyles.HexNumber));
            }
            GameTipsEntry gte = (GameTipsEntry)listGameTips.Items[listGameTips.SelectedIndex];
            gte.Tips = txtTip.Text;

            DBCStores.GameTips.ReplaceEntry(gte.Id, gte);
            listGameTips.Items[listGameTips.SelectedIndex] = gte;
        }

        private string FormatTip(string tip)
        {
            string baseText = tip;

            const string regex = @"\|c([0-9a-f]{8})(.*?)\|r";

            Regex r = new Regex(regex, RegexOptions.IgnoreCase);

            _fooList.Clear();
            MatchCollection m = r.Matches(tip);

            int numberMatchs = 0;

            foreach (Match match in m)
            {
                _fooList.Add(new Foo
                {
                    BeginPosition = match.Index - 12 * numberMatchs,
                    Color = match.Value.Substring(2, 8),
                    Lenght = match.Length - 12,
                });
                numberMatchs++;
            }

            return r.Replace(baseText, "$2");
        }

        private readonly List<Foo> _fooList = new List<Foo>(); 

        private class Foo
        {
            public string Color { get; set; }
            public int BeginPosition { get; set; }
            public int Lenght { get; set; }
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            try
            {
                GameTipsEntry t = new GameTipsEntry
                    {
                        Id = DBCStores.GameTips.MaxKey + 1,
                        //Tips = "|cffffd100Tip :|r New Tip"
                        Tips = Loc.GetString("NewGameTips")
                    };

                listGameTips.Items.Add(t);
                DBCStores.GameTips.AddEntry(t.Id, t);

                listGameTips.SelectedIndex = listGameTips.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnDelTip_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette astuce de la liste ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            if(choix == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    GameTipsEntry t = (GameTipsEntry) listGameTips.SelectedItem;

                    --listGameTips.SelectedIndex;

                    DBCStores.GameTips.RemoveEntry(t.Id);
                    listGameTips.Items.Remove(t);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveGameTipsEditorFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
