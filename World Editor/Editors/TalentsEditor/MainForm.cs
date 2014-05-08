#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DBCLib.Structures335;
using World_Editor.DBC;

#endregion

namespace World_Editor.Editors.TalentsEditor
{
    public partial class MainForm : EditorForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listTalentTab.Items.Clear();
            foreach (TalentTabEntry t in DBCStores.TalentTab.Records)
                listTalentTab.Items.Add(t);

            listTalentTab.SelectedIndex = 0;
        }

        private void listTalentTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            listTalents.Items.Clear();
            TalentTabEntry tab = (TalentTabEntry) listTalentTab.SelectedItem;

            foreach (TalentEntry t in DBCStores.Talent.Records.Where(th => th.TabId == tab.Id))
            {
                listTalents.Items.Add(t);
            }

            listTalents.SelectedIndex = 0;
            LoadTalentTab();
        }

        private void LoadTalentTab()
        {
            TalentTabEntry tb = (TalentTabEntry) listTalentTab.SelectedItem;
            talentsUserControl.SetTalents(listTalents.Items.Cast<TalentEntry>().ToList(), tb.Id);
        }

        private void listTalents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry) listTalents.SelectedItem;

            txtId.Text = t.Id.ToString();
            txtRow.Text = t.Row.ToString();
            txtCol.Text = t.Col.ToString();
            txtSpell0.Text = t.RankId[0].ToString();
            txtSpell1.Text = t.RankId[1].ToString();
            txtSpell2.Text = t.RankId[2].ToString();
            txtSpell3.Text = t.RankId[3].ToString();
            txtSpell4.Text = t.RankId[4].ToString();
            txtReqTalent.Text = t.ReqTalent[0].ToString();
            txtReqRank.Text = t.ReqRank[0].ToString();
            checkFlags.Checked = Convert.ToBoolean(t.Flags);
            txtPetFlags0.Text = t.AllowForPetFlags[0].ToString();
            txtPetFlags1.Text = t.AllowForPetFlags[1].ToString();
        }

        private void btnEditTalentTab_Click(object sender, EventArgs e)
        {
            World_Editor.TalentsEditor.Dialogs.TalentTabsEditor d =
                new World_Editor.TalentsEditor.Dialogs.TalentTabsEditor();
            d.ShowDialog();

            listTalentTab.Items.Clear();
            foreach (TalentTabEntry t in DBCStores.TalentTab.Records)
                listTalentTab.Items.Add(t);

            listTalentTab.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveTalentsEditorFiles(new TalentComparer());
                MessageBox.Show("Sauvegarde terminée !", "Réussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message);
            }
        }

        private void UpdateTalentTextChanged(object sender, EventArgs e)
        {
            if (listTalents.SelectedItem == null)
                return;

            TalentEntry t = (TalentEntry) listTalents.SelectedItem;

            if (sender == txtRow)
            {
                t.Row = Misc.ParseToUInt(txtRow.Text);
                listTalents.Items[listTalents.SelectedIndex] = t;
            }
            else if (sender == txtCol)
            {
                t.Col = Misc.ParseToUInt(txtCol.Text);
                listTalents.Items[listTalents.SelectedIndex] = t;
            }
            else if (sender == txtSpell0)
            {
                t.RankId[0] = Misc.ParseToUInt(txtSpell0.Text);
            }
            else if (sender == txtSpell1)
            {
                t.RankId[1] = Misc.ParseToUInt(txtSpell1.Text);
            }
            else if (sender == txtSpell2)
            {
                t.RankId[2] = Misc.ParseToUInt(txtSpell2.Text);
            }
            else if (sender == txtSpell3)
            {
                t.RankId[3] = Misc.ParseToUInt(txtSpell3.Text);
            }
            else if (sender == txtSpell4)
            {
                t.RankId[4] = Misc.ParseToUInt(txtSpell4.Text);
            }
            else if (sender == txtReqTalent)
            {
                t.ReqTalent[0] = Misc.ParseToUInt(txtReqTalent.Text);
            }
            else if (sender == txtReqRank)
            {
                t.ReqRank[0] = Misc.ParseToUInt(txtReqRank.Text);
            }
            else if (sender == txtPetFlags0)
            {
                t.AllowForPetFlags[0] = Misc.ParseToUInt(txtPetFlags0.Text);
            }
            else if (sender == txtPetFlags1)
            {
                t.AllowForPetFlags[1] = Misc.ParseToUInt(txtPetFlags1.Text);
            }
            else
            {
                return;
            }

            LoadTalentTab();
        }

        //--------------------
        // TALENTS USER CONTROL EVENTS
        //--------------------
        private void talentsUserControl_TalentAddedEvent(Control.TalentUserControlEventArgs talentArgs)
        {
            if (talentArgs == null)
                return;

            TalentEntry newTalent = talentArgs.GetTalent();

            if (newTalent == null)
                return;

            listTalents.Items.Add(newTalent);
            listTalents.SelectedItem = newTalent;
        }

        private void talentsUserControl_TalentDeletedEvent(Control.TalentUserControlEventArgs talentArgs)
        {
            if (talentArgs == null || talentArgs.GetTalent() == null)
                return;

            TalentEntry talent = talentArgs.GetTalent();

            listTalents.Items.Remove(talent);
            listTalents.SelectedIndex = 0;
        }

        private void talentsUserControl_TalentSelectedEvent(Control.TalentUserControlEventArgs talentArgs)
        {
            if (talentArgs == null || talentArgs.GetTalent() == null)
                return;

            TalentEntry talent = talentArgs.GetTalent();

            listTalents.SelectedItem = talent;
        }

        private void talentsUserControl_ControlPaintTime(Control.TalentUserControlEventArgs talentArgs)
        {
            if (talentArgs == null)
                return;

            lblRenderTime.Text = "Render time : " + talentArgs.GetTime() + " ms";
        }


        //--------------------
        // INNER CLASS
        //--------------------
        private class TalentComparer : IComparer<TalentEntry>
        {
            public int Compare(TalentEntry x, TalentEntry y)
            {
                if (x == null || y == null)
                    return 0;

                return x.TabId.CompareTo(y.TabId);
            }
        }
    }
}