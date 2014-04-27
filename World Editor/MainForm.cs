using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AntiBrouillard;
using World_Editor.Database;
using World_Editor.Database.Emulators;
using World_Editor.DBC;
using World_Editor.Editors;
using World_Editor.Model;
using World_Editor.ProjectsEditor;

namespace World_Editor
{
    public partial class MainForm : Form
    {
        private readonly ProjectSettings _projConf = new ProjectSettings();
        private List<ProjectModel> _projects = new List<ProjectModel>();
        private ProjectModel _lastproject;
        private readonly List<EditorForm> _editorList = new List<EditorForm>();

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

                foreach (ProjectModel p in _projects)
                {
                    listProjects.Items.Add(p);

                    if (p.IsLast)
                        _lastproject = p;
                }

                listProjects.SelectedItem = _lastproject;
            }
            catch (Exception ex)
            {
                Log.E(ex);
            }
        }

        private void btnValidateProject_Click(object sender, EventArgs e)
        {
            if (btnValidateProject.Text == "Valider")
            {
                EnterInEditionMode();
            }
            else if (btnValidateProject.Text == "Modifier")
            {
                EnterInProjectChoiceMode();
            }
        }

        private void EnterInEditionMode()
        {
            ProjectModel selectedProject = null;
            foreach (ProjectModel p in _projects)
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
                ProjectManager.SelectedProject = selectedProject;
            }

            _projConf.Projects = _projects;
            _projConf.Save();

            try
            {
                if (Properties.Settings.Default.OptionUseDatabase)
                {
                    ProjectManager.SelectedProject.GetMysqlConnector();
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

        private void EnterInProjectChoiceMode()
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

        private void menuProjectsEditor_Click(object sender, EventArgs e)
        {
            ProjectsEditor.MainForm d = new ProjectsEditor.MainForm();
            d.ShowDialog();
            _projConf.Projects = d.GetProjectModels();
            _projConf.Save();

            listProjects.Items.Clear();
            _projects = _projConf.Projects;


            foreach (ProjectModel p in _projects)
            {
                listProjects.Items.Add(p);

                if (p.IsLast)
                    _lastproject = p;
            }

            try
            {
                listProjects.SelectedItem = _lastproject;
            }
            catch (Exception ex)
            {
                Log.E(ex);
            }
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
            lblInfos.Visible = false;
            lblInfos.Text = "";
            ChangeEnableEditors(true, true);
            ShowAndBringToFrontEditor<TalentsEditor.MainForm>();
        }



        private void menuProfessionsEditor_Click(object sender, EventArgs e)
        {
            lblInfos.ForeColor = Color.Red;
            lblInfos.Visible = true;
            lblInfos.Text = "Chargement en cours, cela peut prendre un certain temps.";
            Refresh();
            DBCStores.LoadProfessionEditorFiles();
            lblInfos.Visible = false;
            lblInfos.Text = "";

            ShowAndBringToFrontEditor<ProfessionEditor.MainForm>();
        }

        private void StartEditor(object sender, EventArgs e)
        {
            if (sender == menuAchievementsEditor || sender == toolAchievementsEditor)
            {
                ShowAndBringToFrontEditor<AchievementsEditor.MainForm>();
            }
            else if (sender == menuTitlesEditor || sender == toolTitlesEditor)
            {
                ShowAndBringToFrontEditor<TitlesEditor.MainForm>();
            }
            else if (sender == menuFactionsEditor || sender == toolFactionsEditor)
            {
                ShowAndBringToFrontEditor<FactionsEditor.MainForm>();
            }
            else if (sender == menuGameTipsEditor || sender == toolGameTipsEditor)
            {
                ShowAndBringToFrontEditor<Editors.GameTipsEditor.MainForm>();
            }
            else if (/*sender == menuNamesReservedEditor ||*/ sender == toolNamesReservedEditor)
            {
                ShowAndBringToFrontEditor<NamesReservedEditor.MainForm>();
            }
            else if (sender == menuRacesEditor || sender == toolRacesEditor)
            {
                //ShowAndBringToFrontEditor<RacesEditor.MainForm>();
            }
            else if (sender == menuClassesEditor || sender == toolClassesEditor)
            {
                //ShowAndBringToFrontEditor<ClassesEditor.MainForm>();
            }
            else if (sender == menuPOIsEditor || sender == toolPOIsEditor)
            {
                ShowAndBringToFrontEditor<POIsEditor.MainForm>();
            }
            else if (sender == menuMapsEditor || sender == toolMapsEditor)
            {
                //ShowAndBringToFrontEditor<MapsEditor.MainForm>();
            }
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
            return _editorList.All(editor => !editor.Visible);
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
            toolNamesReservedEditor.Enabled = value;

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



        private EditorForm GetEditorInstance<T>() where T : EditorForm, new()
        {
            if (_editorList.OfType<T>().Any())
            {
                return _editorList.OfType<T>().First();
            }

            EditorForm mainForm = new T
            {
                MdiParent = this
            };
            _editorList.Add(mainForm);

            return mainForm;
        }

        private void ShowAndBringToFrontEditor<T>() where T : EditorForm, new()
        {
            EditorForm editor = GetEditorInstance<T>();
            if (editor != null)
            {
                editor.Show();
                editor.BringToFront();
            }
        }

    }
}
