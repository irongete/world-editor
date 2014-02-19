using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using World_Editor.Database;
using World_Editor.Database.Emulators;
using World_Editor.DBC;
using World_Editor.ProjectsEditor;

namespace World_Editor
{
    public partial class MainForm : Form
    {
        private readonly ProjectSettings _projConf = new ProjectSettings();
        private List<Project> _projects = new List<Project>();
        private Project _lastproject;

        public delegate void FinChargement();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblInfos.Text = "";
            lblInfos.Visible = false;
            ChangeEnableEditors(false);
            menuUseDB.Checked = Properties.Settings.Default.OptionUseDatabase;

            try
            {
                _projConf.Reload();
                listProjects.Items.Clear();

                _projects = _projConf.Projects;

                foreach (Project p in _projects)
                {
                    listProjects.Items.Add(p); 

                    if (p.IsLast)
                        _lastproject = p;
                }

                listProjects.SelectedItem = _lastproject;
            }
            catch (Exception) { }
        }

        private void btnValidateProject_Click(object sender, EventArgs e)
        {
            if (btnValidateProject.Text == "Valider")
            {
                Project selectedProject = null;
                foreach (Project p in _projects)
                {
                    p.IsLast = false;

                    if (listProjects.Items[listProjects.SelectedIndex] == p)
                    {
                        selectedProject = p;
                    }
                }

                if (selectedProject != null)
                {
                    selectedProject.IsLast = true;
                    ProjectManager.ProjectName = selectedProject.Name;
                    ProjectManager.ProjectDirectory = selectedProject.Path;
                    ProjectManager.WowDirectory = selectedProject.WowDir;
                }

                _projConf.Projects = _projects;
                _projConf.Save();

                try
                {
                    if (Properties.Settings.Default.OptionUseDatabase)
                    {
                        Core c;
                        switch (selectedProject.Core)
                        {
                            case 1:
                                c = new Arcemu();
                                break;
                            case 2:
                                c = new Mangos();
                                break;
                            case 3:
                                c = new Trinity();
                                break;
                            default:
                                throw new Exception("No Core defined");
                        }

                        ProjectManager.Connection = new MySqlConnector(selectedProject.Host,
                            selectedProject.Database, selectedProject.User, selectedProject.Password, c);
                    }

                    DBCStores.InitFiles();

                    Stormlib.MPQArchiveLoader.Instance.Init();

                    ChangeEnableEditors(true);
                    listProjects.Enabled = false;
                    btnValidateProject.Text = "Modifier";
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show(ex.Message);
                }
            }
            else if (btnValidateProject.Text == "Modifier")
            {
                if (!AllEditorsClosed())
                {
                    MessageBox.Show("Vous devez fermer tous les éditeurs pour pouvoir changer de projet.");
                    return;
                }
                ChangeEnableEditors(false);
                listProjects.Enabled = true;
                btnValidateProject.Text = "Valider";
            }
        }

        private void menuProjectsEditor_Click(object sender, EventArgs e)
        {
            ProjectsEditor.MainForm d = new ProjectsEditor.MainForm();
            d.ShowDialog();
            _projConf.Projects = d.Projects;
            _projConf.Save();

            listProjects.Items.Clear();
            _projects = _projConf.Projects;


            foreach (Project p in _projects)
            {
                listProjects.Items.Add(p);

                if (p.IsLast)
                    _lastproject = p;
            }

            try
            {
                listProjects.SelectedItem = _lastproject;
            }
            catch (Exception) { }
        }

        private void menuTalentsEditor_Click(object sender, EventArgs e)
        {
            lblInfos.ForeColor = Color.Red;
            lblInfos.Visible = true;
            lblInfos.Text = "Chargement en cours, cela peut prendre un certain temps.";
            ChangeEnableEditors(false, true);
            Thread t = new Thread(LoadTalentsEditorFiles)
                {
                    IsBackground = true
                };
            t.Start();
        }

        private void LoadTalentsEditorFiles()
        {
            DBCStores.LoadTalentsEditorFiles();
            Invoke((FinChargement)TalentsEditorFilesLoaded);
        }

        private void TalentsEditorFilesLoaded()
        {
            TalentsEditor.MainForm d = TalentsEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            lblInfos.Visible = false;
            lblInfos.Text = "";
            ChangeEnableEditors(true, true);
            d.Show();
            d.BringToFront();
        }

        private void menuFactionsEditor_Click(object sender, EventArgs e)
        {
            FactionsEditor.MainForm d = FactionsEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }

        private void menuProfessionsEditor_Click(object sender, EventArgs e)
        {
            ProfessionEditor.MainForm d = ProfessionEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            lblInfos.ForeColor = Color.Red;
            lblInfos.Visible = true;
            lblInfos.Text = "Chargement en cours, cela peut prendre un certain temps.";
            Refresh();
            DBCStores.LoadProfessionEditorFiles();
            lblInfos.Visible = false;
            lblInfos.Text = "";
            d.Show();
            d.BringToFront();
        }

        private void menuTitlesEditor_Click(object sender, EventArgs e)
        {
            TitlesEditor.MainForm d = TitlesEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }

        private void menuAchievementsEditor_Click(object sender, EventArgs e)
        {
            AchievementsEditor.MainForm d = AchievementsEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }

        private void menuRacesEditor_Click(object sender, EventArgs e)
        {
            RacesEditor.MainForm d = RacesEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }

        private void menuClassesEditor_Click(object sender, EventArgs e)
        {
            ClassesEditor.MainForm d = ClassesEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }

        private void menuPOIsEditor_Click(object sender, EventArgs e)
        {
            POIsEditor.MainForm d = POIsEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }

        private void menuMapsEditor_Click(object sender, EventArgs e)
        {
            MapsEditor.MainForm d = MapsEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Permet de tester si tous les éditeurs sont fermés
        /// </summary>
        /// <returns>Retourne true si tous les éditeurs sont fermés</returns>
        private bool AllEditorsClosed()
        {
            return FactionsEditor.MainForm.m_factionsEditor == null &&
                   ProfessionEditor.MainForm.m_professionsEditor == null &&
                   TalentsEditor.MainForm.m_talentsEditor == null &&
                   TitlesEditor.MainForm.m_titlesEditor == null &&
                   AchievementsEditor.MainForm.m_achievementsEditor == null &&
                   RacesEditor.MainForm.m_racesEditor == null &&
                   ClassesEditor.MainForm.m_classesEditor == null &&
                   POIsEditor.MainForm.m_poisEditor == null &&
                   MapsEditor.MainForm.m_mapsEditor == null;
        }

        /// <summary>
        /// Permet d'activer/désactiver tous les boutons des éditeurs selon la valeur de "value".
        /// Utilisé lorsque le projet est chargé ou non.
        /// </summary>
        /// <param name="value">True pour activier, False pour les désactiver</param>
        private void ChangeEnableEditors(bool value, bool all = false)
        {
            menuTalentsEditor.Enabled = value;
            menuFactionsEditor.Enabled = value;
            menuProfessionsEditor.Enabled = value;
            menuTitlesEditor.Enabled = value;
            menuAchievementsEditor.Enabled = value;
            menuRacesEditor.Enabled = value;
            menuClassesEditor.Enabled = value;
            menuPOIsEditor.Enabled = value;
            menuMapsEditor.Enabled = value;
            menuGameTipsEditor.Enabled = value;
            menuUseDB.Enabled = !value;

            toolTalentsEditor.Enabled = value;
            toolFactionsEditor.Enabled = value;
            toolTitlesEditor.Enabled = value;
            toolAchievementsEditor.Enabled = value;
            toolProfessionsEditor.Enabled = value;
            toolRacesEditor.Enabled = value;
            toolClassesEditor.Enabled = value;
            toolPOIsEditor.Enabled = value;
            toolMapsEditor.Enabled = value;
            toolGameTipsEditor.Enabled = value;

            générerUnItemdbcToolStripMenuItem.Enabled = value;

            if (all)
            {
                menuProjectsEditor.Enabled = false;
                btnValidateProject.Enabled = value;
            }
            else
            {
                menuProjectsEditor.Enabled = !value;
            }
        }

        private void générerUnItemdbcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemDbcGenerator.MainForm d = new ItemDbcGenerator.MainForm();
            d.ShowDialog();
        }

        private void menuUseDB_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OptionUseDatabase)
            {
                Properties.Settings.Default.OptionUseDatabase = false;
                menuUseDB.Checked = false;
            }
            else
            {
                Properties.Settings.Default.OptionUseDatabase = true;
                menuUseDB.Checked = true;
            }
        }

        private void menuGameTipsEditor_Click(object sender, EventArgs e)
        {
            var d = Editors.GameTipsEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }
    }
}
