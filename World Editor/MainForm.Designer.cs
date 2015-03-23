namespace World_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblInfos = new System.Windows.Forms.Label();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTalentsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMapsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClassesEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFactionsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAchievementsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfessionsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPOIsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRacesEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitlesEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGameTipsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNamesReservedEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGemsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.générerUnItemdbcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProjectsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUseDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolTalentsEditor = new System.Windows.Forms.ToolStripButton();
            this.toolMapsEditor = new System.Windows.Forms.ToolStripButton();
            this.toolClassesEditor = new System.Windows.Forms.ToolStripButton();
            this.toolFactionsEditor = new System.Windows.Forms.ToolStripButton();
            this.toolAchievementsEditor = new System.Windows.Forms.ToolStripButton();
            this.toolProfessionsEditor = new System.Windows.Forms.ToolStripButton();
            this.toolPOIsEditor = new System.Windows.Forms.ToolStripButton();
            this.toolRacesEditor = new System.Windows.Forms.ToolStripButton();
            this.toolTitlesEditor = new System.Windows.Forms.ToolStripButton();
            this.toolGameTipsEditor = new System.Windows.Forms.ToolStripButton();
            this.toolNamesReservedEditor = new System.Windows.Forms.ToolStripButton();
            this.toolGemsEditor = new System.Windows.Forms.ToolStripButton();
            this.btnValidateProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listProjects = new System.Windows.Forms.ComboBox();
            this.toolGemsEditor = new System.Windows.Forms.ToolStripButton();
            this.menuGemsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfos
            // 
            this.lblInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(371, 92);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(260, 33);
            this.lblInfos.TabIndex = 8;
            this.lblInfos.Text = "lblInfos";
            this.lblInfos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editeursToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1008, 24);
            this.topMenu.TabIndex = 12;
            this.topMenu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editeursToolStripMenuItem
            // 
            this.editeursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTalentsEditor,
            this.menuMapsEditor,
            this.menuClassesEditor,
            this.menuFactionsEditor,
            this.menuAchievementsEditor,
            this.menuProfessionsEditor,
            this.menuPOIsEditor,
            this.menuRacesEditor,
            this.menuTitlesEditor,
            this.menuGameTipsEditor,
            this.menuNamesReservedEditor,
            this.menuGemsEditor,
            this.toolStripSeparator1,
            this.générerUnItemdbcToolStripMenuItem});
            this.editeursToolStripMenuItem.Name = "editeursToolStripMenuItem";
            this.editeursToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.editeursToolStripMenuItem.Text = "Editeurs";
            // 
            // menuTalentsEditor
            // 
            this.menuTalentsEditor.Image = global::World_Editor.Properties.Resources.icon_talents;
            this.menuTalentsEditor.Name = "menuTalentsEditor";
            this.menuTalentsEditor.Size = new System.Drawing.Size(203, 22);
            this.menuTalentsEditor.Text = "Editeur d\'arbres de talents";
            this.menuTalentsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuMapsEditor
            // 
            this.menuMapsEditor.Image = global::World_Editor.Properties.Resources.icon_maps;
            this.menuMapsEditor.Name = "menuMapsEditor";
            this.menuMapsEditor.Size = new System.Drawing.Size(203, 22);
            this.menuMapsEditor.Text = "Editeur de cartes";
            this.menuMapsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuClassesEditor
            // 
            this.menuClassesEditor.Image = global::World_Editor.Properties.Resources.icon_classes;
            this.menuClassesEditor.Name = "menuClassesEditor";
            this.menuClassesEditor.Size = new System.Drawing.Size(203, 22);
            this.menuClassesEditor.Text = "Editeur de classes";
            this.menuClassesEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuFactionsEditor
            // 
            this.menuFactionsEditor.Image = global::World_Editor.Properties.Resources.icon_factions;
            this.menuFactionsEditor.Name = "menuFactionsEditor";
            this.menuFactionsEditor.Size = new System.Drawing.Size(203, 22);
            this.menuFactionsEditor.Text = "Editeur de factions";
            this.menuFactionsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuAchievementsEditor
            // 
            this.menuAchievementsEditor.Image = global::World_Editor.Properties.Resources.icon_achievements;
            this.menuAchievementsEditor.Name = "menuAchievementsEditor";
            this.menuAchievementsEditor.Size = new System.Drawing.Size(203, 22);
            this.menuAchievementsEditor.Text = "Editeur de haut-faits";
            this.menuAchievementsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuProfessionsEditor
            // 
            this.menuProfessionsEditor.Image = global::World_Editor.Properties.Resources.icon_professions;
            this.menuProfessionsEditor.Name = "menuProfessionsEditor";
            this.menuProfessionsEditor.Size = new System.Drawing.Size(203, 22);
            this.menuProfessionsEditor.Text = "Editeur de métiers";
            this.menuProfessionsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuPOIsEditor
            // 
            this.menuPOIsEditor.Image = global::World_Editor.Properties.Resources.icon_poi;
            this.menuPOIsEditor.Name = "menuPOIsEditor";
            this.menuPOIsEditor.Size = new System.Drawing.Size(203, 22);
            this.menuPOIsEditor.Text = "Editeur de points d\'intérêts";
            this.menuPOIsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuRacesEditor
            // 
            this.menuRacesEditor.Image = global::World_Editor.Properties.Resources.icon_races;
            this.menuRacesEditor.Name = "menuRacesEditor";
            this.menuRacesEditor.Size = new System.Drawing.Size(203, 22);
            this.menuRacesEditor.Text = "Editeur de races";
            this.menuRacesEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuTitlesEditor
            // 
            this.menuTitlesEditor.Image = global::World_Editor.Properties.Resources.icon_titles;
            this.menuTitlesEditor.Name = "menuTitlesEditor";
            this.menuTitlesEditor.Size = new System.Drawing.Size(203, 22);
            this.menuTitlesEditor.Text = "Editeur de titres";
            this.menuTitlesEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuGameTipsEditor
            // 
            this.menuGameTipsEditor.Name = "menuGameTipsEditor";
            this.menuGameTipsEditor.Size = new System.Drawing.Size(203, 22);
            this.menuGameTipsEditor.Text = "Editeur de game tips";
            this.menuGameTipsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuNamesReservedEditor
            // 
            this.menuNamesReservedEditor.Name = "menuNamesReservedEditor";
            this.menuNamesReservedEditor.Size = new System.Drawing.Size(203, 22);
            this.menuNamesReservedEditor.Text = "Editeur de noms réservés";
            this.menuNamesReservedEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // menuGemsEditor
            // 
            this.menuGemsEditor.Name = "menuGemsEditor";
            this.menuGemsEditor.Size = new System.Drawing.Size(203, 22);
            this.menuGemsEditor.Text = "Editeur de gemmes";
            this.menuGemsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // générerUnItemdbcToolStripMenuItem
            // 
            this.générerUnItemdbcToolStripMenuItem.Name = "générerUnItemdbcToolStripMenuItem";
            this.générerUnItemdbcToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.générerUnItemdbcToolStripMenuItem.Text = "Générer un Item.dbc";
            this.générerUnItemdbcToolStripMenuItem.Click += new System.EventHandler(this.StartEditor);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProjectsEditor,
            this.menuUseDB});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menuProjectsEditor
            // 
            this.menuProjectsEditor.Name = "menuProjectsEditor";
            this.menuProjectsEditor.Size = new System.Drawing.Size(160, 22);
            this.menuProjectsEditor.Text = "Editeur de projets";
            this.menuProjectsEditor.Click += new System.EventHandler(this.menuProjectsEditor_Click);
            // 
            // menuUseDB
            // 
            this.menuUseDB.Name = "menuUseDB";
            this.menuUseDB.Size = new System.Drawing.Size(160, 22);
            this.menuUseDB.Text = "Utiliser BdD";
            this.menuUseDB.Click += new System.EventHandler(this.menuUseDB_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTalentsEditor,
            this.toolMapsEditor,
            this.toolClassesEditor,
            this.toolFactionsEditor,
            this.toolAchievementsEditor,
            this.toolProfessionsEditor,
            this.toolPOIsEditor,
            this.toolRacesEditor,
            this.toolTitlesEditor,
            this.toolGameTipsEditor,
            this.toolNamesReservedEditor,
            this.toolGemsEditor});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip.TabIndex = 14;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolTalentsEditor
            // 
            this.toolTalentsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTalentsEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolTalentsEditor.Image")));
            this.toolTalentsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTalentsEditor.Name = "toolTalentsEditor";
            this.toolTalentsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolTalentsEditor.ToolTipText = "Editeur d\'arbres de talents";
            this.toolTalentsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolMapsEditor
            // 
            this.toolMapsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMapsEditor.Image = global::World_Editor.Properties.Resources.icon_maps;
            this.toolMapsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMapsEditor.Name = "toolMapsEditor";
            this.toolMapsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolMapsEditor.ToolTipText = "Editeur de cartes";
            this.toolMapsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolClassesEditor
            // 
            this.toolClassesEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolClassesEditor.Image = global::World_Editor.Properties.Resources.icon_classes;
            this.toolClassesEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClassesEditor.Name = "toolClassesEditor";
            this.toolClassesEditor.Size = new System.Drawing.Size(23, 22);
            this.toolClassesEditor.ToolTipText = "Editeur de classes";
            this.toolClassesEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolFactionsEditor
            // 
            this.toolFactionsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFactionsEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolFactionsEditor.Image")));
            this.toolFactionsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFactionsEditor.Name = "toolFactionsEditor";
            this.toolFactionsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolFactionsEditor.ToolTipText = "Editeur de factions";
            this.toolFactionsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolAchievementsEditor
            // 
            this.toolAchievementsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAchievementsEditor.Image = global::World_Editor.Properties.Resources.icon_achievements;
            this.toolAchievementsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAchievementsEditor.Name = "toolAchievementsEditor";
            this.toolAchievementsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolAchievementsEditor.ToolTipText = "Editeur de haut-faits";
            this.toolAchievementsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolProfessionsEditor
            // 
            this.toolProfessionsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolProfessionsEditor.Image = global::World_Editor.Properties.Resources.icon_professions;
            this.toolProfessionsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProfessionsEditor.Name = "toolProfessionsEditor";
            this.toolProfessionsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolProfessionsEditor.ToolTipText = "Editeur de métiers";
            this.toolProfessionsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolPOIsEditor
            // 
            this.toolPOIsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPOIsEditor.Image = global::World_Editor.Properties.Resources.icon_poi;
            this.toolPOIsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPOIsEditor.Name = "toolPOIsEditor";
            this.toolPOIsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolPOIsEditor.ToolTipText = "Editeur de points d\'intérêts";
            this.toolPOIsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolRacesEditor
            // 
            this.toolRacesEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRacesEditor.Image = global::World_Editor.Properties.Resources.icon_races;
            this.toolRacesEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRacesEditor.Name = "toolRacesEditor";
            this.toolRacesEditor.Size = new System.Drawing.Size(23, 22);
            this.toolRacesEditor.ToolTipText = "Editeur de races";
            this.toolRacesEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolTitlesEditor
            // 
            this.toolTitlesEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTitlesEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolTitlesEditor.Image")));
            this.toolTitlesEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTitlesEditor.Name = "toolTitlesEditor";
            this.toolTitlesEditor.Size = new System.Drawing.Size(23, 22);
            this.toolTitlesEditor.ToolTipText = "Editeur de titres";
            this.toolTitlesEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolGameTipsEditor
            // 
            this.toolGameTipsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGameTipsEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolGameTipsEditor.Image")));
            this.toolGameTipsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGameTipsEditor.Name = "toolGameTipsEditor";
            this.toolGameTipsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolGameTipsEditor.Text = "Editeur de GameTips";
            this.toolGameTipsEditor.ToolTipText = "Editeur de game tips";
            this.toolGameTipsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolNamesReservedEditor
            // 
            this.toolNamesReservedEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNamesReservedEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolNamesReservedEditor.Image")));
            this.toolNamesReservedEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNamesReservedEditor.Name = "toolNamesReservedEditor";
            this.toolNamesReservedEditor.Size = new System.Drawing.Size(23, 22);
            this.toolNamesReservedEditor.Text = "Editeur de noms réservés";
            this.toolNamesReservedEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // toolGemsEditor
            // 
            this.toolGemsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGemsEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolGemsEditor.Image")));
            this.toolGemsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGemsEditor.Name = "toolGemsEditor";
            this.toolGemsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolGemsEditor.Text = "Editeur de gemmes";
            this.toolGemsEditor.Click += new System.EventHandler(this.StartEditor);
            // 
            // btnValidateProject
            // 
            this.btnValidateProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidateProject.Location = new System.Drawing.Point(925, 27);
            this.btnValidateProject.Name = "btnValidateProject";
            this.btnValidateProject.Size = new System.Drawing.Size(71, 21);
            this.btnValidateProject.TabIndex = 16;
            this.btnValidateProject.Text = "Valider";
            this.btnValidateProject.UseVisualStyleBackColor = true;
            this.btnValidateProject.Click += new System.EventHandler(this.btnValidateProject_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Projet de travail :";
            // 
            // listProjects
            // 
            this.listProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(739, 27);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(180, 21);
            this.listProjects.TabIndex = 18;
            // 
            // toolGemsEditor
            // 
            this.toolGemsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGemsEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolGemsEditor.Image")));
            this.toolGemsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGemsEditor.Name = "toolGemsEditor";
            this.toolGemsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolGemsEditor.Text = "Editeur de gemmes";
            // 
            // menuGemsEditor
            // 
            this.menuGemsEditor.Name = "menuGemsEditor";
            this.menuGemsEditor.Size = new System.Drawing.Size(203, 22);
            this.menuGemsEditor.Text = "Editeur de gemmes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 734);
            this.Controls.Add(this.listProjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidateProject);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.topMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.topMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfos;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuProjectsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuTalentsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuFactionsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuProfessionsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuTitlesEditor;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolTalentsEditor;
        private System.Windows.Forms.ToolStripButton toolFactionsEditor;
        private System.Windows.Forms.ToolStripButton toolTitlesEditor;
        private System.Windows.Forms.ToolStripMenuItem menuAchievementsEditor;
        private System.Windows.Forms.Button btnValidateProject;
        private System.Windows.Forms.ToolStripButton toolAchievementsEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listProjects;
        private System.Windows.Forms.ToolStripButton toolProfessionsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuRacesEditor;
        private System.Windows.Forms.ToolStripButton toolRacesEditor;
        private System.Windows.Forms.ToolStripMenuItem menuClassesEditor;
        private System.Windows.Forms.ToolStripButton toolClassesEditor;
        private System.Windows.Forms.ToolStripMenuItem menuPOIsEditor;
        private System.Windows.Forms.ToolStripButton toolPOIsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuMapsEditor;
        private System.Windows.Forms.ToolStripButton toolMapsEditor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem générerUnItemdbcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUseDB;
        private System.Windows.Forms.ToolStripMenuItem menuGameTipsEditor;
        private System.Windows.Forms.ToolStripButton toolGameTipsEditor;
        private System.Windows.Forms.ToolStripButton toolNamesReservedEditor;
        private System.Windows.Forms.ToolStripMenuItem menuNamesReservedEditor;
        private System.Windows.Forms.ToolStripButton toolGemsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuGemsEditor;
    }
}

