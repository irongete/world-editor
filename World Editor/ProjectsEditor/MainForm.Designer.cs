namespace World_Editor.ProjectsEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listProjects = new System.Windows.Forms.ComboBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtWowFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWowFolder = new System.Windows.Forms.Button();
            this.btnExtractDbc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDbUser = new System.Windows.Forms.TextBox();
            this.txtDbDatabase = new System.Windows.Forms.TextBox();
            this.txtDbHost = new System.Windows.Forms.TextBox();
            this.btnTestDatabase = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listCores = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProjects
            // 
            this.listProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(12, 12);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(266, 21);
            this.listProjects.TabIndex = 0;
            this.listProjects.SelectedIndexChanged += new System.EventHandler(this.listProjects_SelectedIndexChanged);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(91, 39);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(243, 20);
            this.txtProjectName.TabIndex = 1;
            this.txtProjectName.TextChanged += new System.EventHandler(this.txtProjectName_TextChanged);
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(15, 83);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(248, 20);
            this.txtProjectPath.TabIndex = 2;
            this.txtProjectPath.TextChanged += new System.EventHandler(this.txtProjectPath_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(21, 21);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(312, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(21, 21);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom du projet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chemin du projet";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(269, 81);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(65, 22);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Parcourir";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtWowFolder
            // 
            this.txtWowFolder.Location = new System.Drawing.Point(15, 132);
            this.txtWowFolder.Name = "txtWowFolder";
            this.txtWowFolder.Size = new System.Drawing.Size(248, 20);
            this.txtWowFolder.TabIndex = 9;
            this.txtWowFolder.TextChanged += new System.EventHandler(this.txtWowFolder_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chemin du dossier World Of Warcraft";
            // 
            // btnWowFolder
            // 
            this.btnWowFolder.Location = new System.Drawing.Point(269, 130);
            this.btnWowFolder.Name = "btnWowFolder";
            this.btnWowFolder.Size = new System.Drawing.Size(64, 22);
            this.btnWowFolder.TabIndex = 11;
            this.btnWowFolder.Text = "Parcourir";
            this.btnWowFolder.UseVisualStyleBackColor = true;
            this.btnWowFolder.Click += new System.EventHandler(this.btnWowFolder_Click);
            // 
            // btnExtractDbc
            // 
            this.btnExtractDbc.Location = new System.Drawing.Point(60, 323);
            this.btnExtractDbc.Name = "btnExtractDbc";
            this.btnExtractDbc.Size = new System.Drawing.Size(105, 22);
            this.btnExtractDbc.TabIndex = 12;
            this.btnExtractDbc.Text = "Extraire les DBCs";
            this.btnExtractDbc.UseVisualStyleBackColor = true;
            this.btnExtractDbc.Click += new System.EventHandler(this.btnExtractDbc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDbHost);
            this.groupBox1.Controls.Add(this.txtDbDatabase);
            this.groupBox1.Controls.Add(this.txtDbUser);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDbPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 127);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de données";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Host";
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Location = new System.Drawing.Point(65, 97);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.Size = new System.Drawing.Size(247, 20);
            this.txtDbPassword.TabIndex = 1;
            this.txtDbPassword.TextChanged += new System.EventHandler(this.txtDbPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Password";
            // 
            // txtDbUser
            // 
            this.txtDbUser.Location = new System.Drawing.Point(65, 71);
            this.txtDbUser.Name = "txtDbUser";
            this.txtDbUser.Size = new System.Drawing.Size(247, 20);
            this.txtDbUser.TabIndex = 5;
            this.txtDbUser.TextChanged += new System.EventHandler(this.txtDbUser_TextChanged);
            // 
            // txtDbDatabase
            // 
            this.txtDbDatabase.Location = new System.Drawing.Point(65, 45);
            this.txtDbDatabase.Name = "txtDbDatabase";
            this.txtDbDatabase.Size = new System.Drawing.Size(247, 20);
            this.txtDbDatabase.TabIndex = 6;
            this.txtDbDatabase.TextChanged += new System.EventHandler(this.txtDbDatabase_TextChanged);
            // 
            // txtDbHost
            // 
            this.txtDbHost.Location = new System.Drawing.Point(65, 19);
            this.txtDbHost.Name = "txtDbHost";
            this.txtDbHost.Size = new System.Drawing.Size(247, 20);
            this.txtDbHost.TabIndex = 7;
            this.txtDbHost.TextChanged += new System.EventHandler(this.txtDbHost_TextChanged);
            // 
            // btnTestDatabase
            // 
            this.btnTestDatabase.Location = new System.Drawing.Point(171, 323);
            this.btnTestDatabase.Name = "btnTestDatabase";
            this.btnTestDatabase.Size = new System.Drawing.Size(105, 22);
            this.btnTestDatabase.TabIndex = 14;
            this.btnTestDatabase.Text = "Tester BDD";
            this.btnTestDatabase.UseVisualStyleBackColor = true;
            this.btnTestDatabase.Click += new System.EventHandler(this.btnTestDatabase_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Emulateur";
            // 
            // listCores
            // 
            this.listCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCores.FormattingEnabled = true;
            this.listCores.Items.AddRange(new object[] {
            "Arcemu",
            "Mangos",
            "Trinity"});
            this.listCores.Location = new System.Drawing.Point(73, 163);
            this.listCores.Name = "listCores";
            this.listCores.Size = new System.Drawing.Size(260, 21);
            this.listCores.TabIndex = 15;
            this.listCores.SelectedIndexChanged += new System.EventHandler(this.listCores_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 353);
            this.Controls.Add(this.listCores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTestDatabase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExtractDbc);
            this.Controls.Add(this.btnWowFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWowFolder);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProjectPath);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.listProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des projets";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listProjects;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtWowFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWowFolder;
        private System.Windows.Forms.Button btnExtractDbc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDbHost;
        private System.Windows.Forms.TextBox txtDbDatabase;
        private System.Windows.Forms.TextBox txtDbUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTestDatabase;
        private System.Windows.Forms.ComboBox listCores;
    }
}