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
        private const string Valider = "Valider";
        private const string Modifier = "Modifier";

        private readonly ProjectSettings _projConf = new ProjectSettings();
        private List<ProjectModel> _projects = new List<ProjectModel>();
        private ProjectModel _lastproject;
        private readonly List<EditorForm> _editorList = new List<EditorForm>();
        private readonly List<ToolStripItem> _controlsInEditMode = new List<ToolStripItem>();

        public delegate void FinChargement();

        public MainForm()
        {
            InitializeComponent();
            InitializeControlsInEditMode();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblInfos.Text = "";
            lblInfos.Visible = false;
            EnableEditorsMenuButtons(false);
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
            switch (btnValidateProject.Text)
            {
                case Valider:
                    EnterInEditionMode();
                    break;
                case Modifier:
                    EnterInProjectChoiceMode();
                    break;
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

                EnableEditorsMenuButtons(true);
                listProjects.Enabled = false;
                btnValidateProject.Text = Modifier;
            }
            catch (Exception ex)
            {
                Log.E(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void EnterInProjectChoiceMode()
        {
            if (!AreAllEditorsClosed())
            {
                MessageBox.Show("Vous devez fermer tous les éditeurs pour pouvoir changer de projet.");
                return;
            }
            EnableEditorsMenuButtons(false);
            listProjects.Enabled = true;
            btnValidateProject.Text = Valider;
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

        private void StartEditor(object sender, EventArgs e)
        {
            if (sender == menuAchievementsEditor || sender == toolAchievementsEditor)
            {
                ShowAndBringToFrontEditor<Editors.AchievementsEditor.MainForm>();
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
            else if (sender == menuNamesReservedEditor || sender == toolNamesReservedEditor)
            {
                ShowAndBringToFrontEditor<NamesReservedEditor.MainForm>();
            }
            else if (sender == menuGemsEditor || sender == toolGemsEditor)
            {
                ShowAndBringToFrontEditor<GemsEditor.MainForm>();
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
            else if (sender == générerUnItemdbcToolStripMenuItem)
            {
                ItemDbcGenerator.MainForm d = new ItemDbcGenerator.MainForm();
                d.ShowDialog();
            }
            else if (sender == menuTalentsEditor || sender == toolTalentsEditor)
            {
                EnableErrorMessage("Chargement en cours, cela peut prendre un certain temps.");
                Thread t = new Thread(LoadTalentsEditorFiles)
                {
                    IsBackground = true
                };
                t.Start();
            }
            else if (sender == menuProfessionsEditor || sender == toolProfessionsEditor)
            {
                EnableErrorMessage("Chargement en cours, cela peut prendre un certain temps.");
                Thread t = new Thread(LoadProfessionsEditorFiles)
                {
                    IsBackground = true
                };
                t.Start();
            }
        }

        private void LoadTalentsEditorFiles()
        {
            DBCStores.LoadTalentsEditorFiles();
            Invoke((FinChargement)DisableErrorMessage);
            Invoke((FinChargement)ShowAndBringToFrontEditor<Editors.TalentsEditor.MainForm>);
        }

        private void LoadProfessionsEditorFiles()
        {
            DBCStores.LoadProfessionEditorFiles();
            Invoke((FinChargement)DisableErrorMessage);
            Invoke((FinChargement)ShowAndBringToFrontEditor<ProfessionEditor.MainForm>);
        }

        private void EnableErrorMessage(string content)
        {
            lblInfos.ForeColor = Color.Red;
            lblInfos.Visible = true;
            lblInfos.Text = content;
            EnableEditorsMenuButtons(false, true);
        }

        private void DisableErrorMessage()
        {
            lblInfos.Visible = false;
            lblInfos.Text = "";
            EnableEditorsMenuButtons(true, true);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool AreAllEditorsClosed()
        {
            return _editorList.All(editor => !editor.Visible);
        }

        private void EnableEditorsMenuButtons(bool value, bool all = false)
        {
            foreach (ToolStripItem component in _controlsInEditMode)
            {
                component.Enabled = value;
            }

            menuUseDB.Enabled = !value;

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

        private void menuUseDB_Click(object sender, EventArgs e)
        {
            bool actualUseDb = Properties.Settings.Default.OptionUseDatabase;

            Properties.Settings.Default.OptionUseDatabase = !actualUseDb;
            menuUseDB.Checked = !actualUseDb;
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

        private void InitializeControlsInEditMode()
        {
            _controlsInEditMode.Add(menuTalentsEditor);
            _controlsInEditMode.Add(menuFactionsEditor);
            _controlsInEditMode.Add(menuTitlesEditor);
            _controlsInEditMode.Add(menuAchievementsEditor);
            _controlsInEditMode.Add(menuProfessionsEditor);
            _controlsInEditMode.Add(menuRacesEditor);
            _controlsInEditMode.Add(menuClassesEditor);
            _controlsInEditMode.Add(menuPOIsEditor);
            _controlsInEditMode.Add(menuMapsEditor);
            _controlsInEditMode.Add(menuGameTipsEditor);
            _controlsInEditMode.Add(menuNamesReservedEditor);
            _controlsInEditMode.Add(menuGemsEditor);
            _controlsInEditMode.Add(générerUnItemdbcToolStripMenuItem);

            _controlsInEditMode.Add(toolTalentsEditor);
            _controlsInEditMode.Add(toolFactionsEditor);
            _controlsInEditMode.Add(toolTitlesEditor);
            _controlsInEditMode.Add(toolAchievementsEditor);
            _controlsInEditMode.Add(toolProfessionsEditor);
            _controlsInEditMode.Add(toolRacesEditor);
            _controlsInEditMode.Add(toolClassesEditor);
            _controlsInEditMode.Add(toolPOIsEditor);
            _controlsInEditMode.Add(toolMapsEditor);
            _controlsInEditMode.Add(toolGameTipsEditor);
            _controlsInEditMode.Add(toolNamesReservedEditor);
            _controlsInEditMode.Add(toolGemsEditor);
            //_controlsInEditMode.Add(générerUnItemdbcToolStripMenuItem);
        }
    }
}
