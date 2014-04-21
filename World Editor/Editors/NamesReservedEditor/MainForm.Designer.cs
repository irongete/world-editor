namespace World_Editor.NamesReservedEditor
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
            this.lstNamesReserved = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstNicknamesReserved = new System.Windows.Forms.ListBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ajouterNickname = new System.Windows.Forms.Button();
            this.btn_enregistrerNickname = new System.Windows.Forms.Button();
            this.txt_nomNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idNickname = new System.Windows.Forms.TextBox();
            this.btn_deleteNickname = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNamesReserved
            // 
            this.lstNamesReserved.FormattingEnabled = true;
            this.lstNamesReserved.Location = new System.Drawing.Point(3, 3);
            this.lstNamesReserved.Name = "lstNamesReserved";
            this.lstNamesReserved.Size = new System.Drawing.Size(197, 355);
            this.lstNamesReserved.TabIndex = 1;
            this.lstNamesReserved.SelectedIndexChanged += new System.EventHandler(this.lstNamesReserved_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 389);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_nouveau);
            this.tabPage1.Controls.Add(this.btn_enregistrer);
            this.tabPage1.Controls.Add(this.txt_nom);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.lstNamesReserved);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Noms réservés";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_deleteNickname);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_ajouterNickname);
            this.tabPage2.Controls.Add(this.btn_enregistrerNickname);
            this.tabPage2.Controls.Add(this.txt_nomNickname);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_idNickname);
            this.tabPage2.Controls.Add(this.lstNicknamesReserved);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pseudos réservés";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstNicknamesReserved
            // 
            this.lstNicknamesReserved.FormattingEnabled = true;
            this.lstNicknamesReserved.Location = new System.Drawing.Point(3, 3);
            this.lstNicknamesReserved.Name = "lstNicknamesReserved";
            this.lstNicknamesReserved.Size = new System.Drawing.Size(197, 355);
            this.lstNicknamesReserved.TabIndex = 2;
            this.lstNicknamesReserved.SelectedIndexChanged += new System.EventHandler(this.lstNicknamesReserved_SelectedIndexChanged);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(319, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(55, 20);
            this.txt_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(209, 58);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(165, 20);
            this.txt_nom.TabIndex = 4;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(290, 332);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(86, 23);
            this.btn_enregistrer.TabIndex = 5;
            this.btn_enregistrer.Text = "Sauvegarder";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(209, 95);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(75, 23);
            this.btn_nouveau.TabIndex = 6;
            this.btn_nouveau.Text = "Ajouter";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modifier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Modifier";
            // 
            // btn_ajouterNickname
            // 
            this.btn_ajouterNickname.Location = new System.Drawing.Point(209, 95);
            this.btn_ajouterNickname.Name = "btn_ajouterNickname";
            this.btn_ajouterNickname.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterNickname.TabIndex = 12;
            this.btn_ajouterNickname.Text = "Ajouter";
            this.btn_ajouterNickname.UseVisualStyleBackColor = true;
            this.btn_ajouterNickname.Click += new System.EventHandler(this.btn_ajouterNickname_Click);
            // 
            // btn_enregistrerNickname
            // 
            this.btn_enregistrerNickname.Location = new System.Drawing.Point(290, 332);
            this.btn_enregistrerNickname.Name = "btn_enregistrerNickname";
            this.btn_enregistrerNickname.Size = new System.Drawing.Size(86, 23);
            this.btn_enregistrerNickname.TabIndex = 11;
            this.btn_enregistrerNickname.Text = "Sauvegarder";
            this.btn_enregistrerNickname.UseVisualStyleBackColor = true;
            this.btn_enregistrerNickname.Click += new System.EventHandler(this.btn_enregistrerNickname_Click);
            // 
            // txt_nomNickname
            // 
            this.txt_nomNickname.Location = new System.Drawing.Point(209, 58);
            this.txt_nomNickname.Name = "txt_nomNickname";
            this.txt_nomNickname.Size = new System.Drawing.Size(165, 20);
            this.txt_nomNickname.TabIndex = 10;
            this.txt_nomNickname.TextChanged += new System.EventHandler(this.txt_nomNickname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            // 
            // txt_idNickname
            // 
            this.txt_idNickname.Enabled = false;
            this.txt_idNickname.Location = new System.Drawing.Point(319, 6);
            this.txt_idNickname.Name = "txt_idNickname";
            this.txt_idNickname.Size = new System.Drawing.Size(55, 20);
            this.txt_idNickname.TabIndex = 8;
            // 
            // btn_deleteNickname
            // 
            this.btn_deleteNickname.Location = new System.Drawing.Point(209, 332);
            this.btn_deleteNickname.Name = "btn_deleteNickname";
            this.btn_deleteNickname.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteNickname.TabIndex = 14;
            this.btn_deleteNickname.Text = "Supprimer";
            this.btn_deleteNickname.UseVisualStyleBackColor = true;
            this.btn_deleteNickname.Click += new System.EventHandler(this.btn_deleteNickname_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(209, 332);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 389);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Réserver des pseudos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNamesReserved;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstNicknamesReserved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ajouterNickname;
        private System.Windows.Forms.Button btn_enregistrerNickname;
        private System.Windows.Forms.TextBox txt_nomNickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_idNickname;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_deleteNickname;

    }
}