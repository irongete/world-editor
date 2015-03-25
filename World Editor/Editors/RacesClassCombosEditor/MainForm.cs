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

namespace World_Editor.RacesClassCombosEditor
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
                DBCStores.LoadRacesClassCombosEditorFiles();
            }
            catch (Exception editor)
            {
                MessageBox.Show("LoadDbcError : " + editor);
                this.Close();
            }

            foreach(ChrRacesEntry race in DBC.DBCStores.ChrRaces.Records)
            {
                lstRaces.Items.Add(race);
            }
            lstRaces.SelectedIndex = lstRaces.Items.Count - 1;
        }

        private void lstRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRaces.SelectedItem == null)
                return;

            ChrRacesEntry raceSelected = (ChrRacesEntry)lstRaces.SelectedItem;

            /*foreach (CharBaseInfoEntry combo in DBCStores.CharBaseInfo.Records.Where(i => i.RaceId == raceSelected.RaceId))
            {
                foreach (ChrClassesEntry classe in DBCStores.ChrClasses.Records)
                {
                    if (classe.ClassId == combo.ClasseId)
                    {
                        Console.WriteLine(classe.Name);
                    }
                }
            }*/
        }
    }
}
