namespace World_Editor.RacesClassCombosEditor
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
            this.lstRaces = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDruid = new System.Windows.Forms.CheckBox();
            this.checkWarlock = new System.Windows.Forms.CheckBox();
            this.checkMage = new System.Windows.Forms.CheckBox();
            this.checkChaman = new System.Windows.Forms.CheckBox();
            this.checkDK = new System.Windows.Forms.CheckBox();
            this.checkPriest = new System.Windows.Forms.CheckBox();
            this.checkRogue = new System.Windows.Forms.CheckBox();
            this.checkHunter = new System.Windows.Forms.CheckBox();
            this.checkPaladin = new System.Windows.Forms.CheckBox();
            this.checkWarrior = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRaces
            // 
            this.lstRaces.FormattingEnabled = true;
            this.lstRaces.Location = new System.Drawing.Point(10, 19);
            this.lstRaces.Name = "lstRaces";
            this.lstRaces.Size = new System.Drawing.Size(135, 277);
            this.lstRaces.TabIndex = 0;
            this.lstRaces.SelectedIndexChanged += new System.EventHandler(this.lstRaces_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstRaces);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Races";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::World_Editor.Properties.Resources.MiniArrow_Right;
            this.pictureBox1.Location = new System.Drawing.Point(170, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDruid);
            this.groupBox2.Controls.Add(this.checkWarlock);
            this.groupBox2.Controls.Add(this.checkMage);
            this.groupBox2.Controls.Add(this.checkChaman);
            this.groupBox2.Controls.Add(this.checkDK);
            this.groupBox2.Controls.Add(this.checkPriest);
            this.groupBox2.Controls.Add(this.checkRogue);
            this.groupBox2.Controls.Add(this.checkHunter);
            this.groupBox2.Controls.Add(this.checkPaladin);
            this.groupBox2.Controls.Add(this.checkWarrior);
            this.groupBox2.Location = new System.Drawing.Point(195, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 305);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classes";
            // 
            // checkDruid
            // 
            this.checkDruid.AutoSize = true;
            this.checkDruid.Location = new System.Drawing.Point(136, 111);
            this.checkDruid.Name = "checkDruid";
            this.checkDruid.Size = new System.Drawing.Size(57, 17);
            this.checkDruid.TabIndex = 9;
            this.checkDruid.Text = "Druide";
            this.checkDruid.UseVisualStyleBackColor = true;
            // 
            // checkWarlock
            // 
            this.checkWarlock.AutoSize = true;
            this.checkWarlock.Location = new System.Drawing.Point(136, 88);
            this.checkWarlock.Name = "checkWarlock";
            this.checkWarlock.Size = new System.Drawing.Size(76, 17);
            this.checkWarlock.TabIndex = 8;
            this.checkWarlock.Text = "Démoniste";
            this.checkWarlock.UseVisualStyleBackColor = true;
            // 
            // checkMage
            // 
            this.checkMage.AutoSize = true;
            this.checkMage.Location = new System.Drawing.Point(136, 65);
            this.checkMage.Name = "checkMage";
            this.checkMage.Size = new System.Drawing.Size(53, 17);
            this.checkMage.TabIndex = 7;
            this.checkMage.Text = "Mage";
            this.checkMage.UseVisualStyleBackColor = true;
            // 
            // checkChaman
            // 
            this.checkChaman.AutoSize = true;
            this.checkChaman.Location = new System.Drawing.Point(136, 42);
            this.checkChaman.Name = "checkChaman";
            this.checkChaman.Size = new System.Drawing.Size(65, 17);
            this.checkChaman.TabIndex = 6;
            this.checkChaman.Text = "Chaman";
            this.checkChaman.UseVisualStyleBackColor = true;
            // 
            // checkDK
            // 
            this.checkDK.AutoSize = true;
            this.checkDK.Location = new System.Drawing.Point(136, 19);
            this.checkDK.Name = "checkDK";
            this.checkDK.Size = new System.Drawing.Size(120, 17);
            this.checkDK.TabIndex = 5;
            this.checkDK.Text = "Chevalier de la Mort";
            this.checkDK.UseVisualStyleBackColor = true;
            // 
            // checkPriest
            // 
            this.checkPriest.AutoSize = true;
            this.checkPriest.Location = new System.Drawing.Point(6, 111);
            this.checkPriest.Name = "checkPriest";
            this.checkPriest.Size = new System.Drawing.Size(54, 17);
            this.checkPriest.TabIndex = 4;
            this.checkPriest.Text = "Prêtre";
            this.checkPriest.UseVisualStyleBackColor = true;
            // 
            // checkRogue
            // 
            this.checkRogue.AutoSize = true;
            this.checkRogue.Location = new System.Drawing.Point(6, 88);
            this.checkRogue.Name = "checkRogue";
            this.checkRogue.Size = new System.Drawing.Size(56, 17);
            this.checkRogue.TabIndex = 3;
            this.checkRogue.Text = "Voleur";
            this.checkRogue.UseVisualStyleBackColor = true;
            // 
            // checkHunter
            // 
            this.checkHunter.AutoSize = true;
            this.checkHunter.Location = new System.Drawing.Point(6, 65);
            this.checkHunter.Name = "checkHunter";
            this.checkHunter.Size = new System.Drawing.Size(70, 17);
            this.checkHunter.TabIndex = 2;
            this.checkHunter.Text = "Chasseur";
            this.checkHunter.UseVisualStyleBackColor = true;
            // 
            // checkPaladin
            // 
            this.checkPaladin.AutoSize = true;
            this.checkPaladin.Location = new System.Drawing.Point(6, 42);
            this.checkPaladin.Name = "checkPaladin";
            this.checkPaladin.Size = new System.Drawing.Size(61, 17);
            this.checkPaladin.TabIndex = 1;
            this.checkPaladin.Text = "Paladin";
            this.checkPaladin.UseVisualStyleBackColor = true;
            // 
            // checkWarrior
            // 
            this.checkWarrior.AutoSize = true;
            this.checkWarrior.Location = new System.Drawing.Point(6, 19);
            this.checkWarrior.Name = "checkWarrior";
            this.checkWarrior.Size = new System.Drawing.Size(63, 17);
            this.checkWarrior.TabIndex = 0;
            this.checkWarrior.Text = "Guerrier";
            this.checkWarrior.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 319);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "RacesClassCombosEditor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRaces;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkWarrior;
        private System.Windows.Forms.CheckBox checkDruid;
        private System.Windows.Forms.CheckBox checkWarlock;
        private System.Windows.Forms.CheckBox checkMage;
        private System.Windows.Forms.CheckBox checkChaman;
        private System.Windows.Forms.CheckBox checkDK;
        private System.Windows.Forms.CheckBox checkPriest;
        private System.Windows.Forms.CheckBox checkRogue;
        private System.Windows.Forms.CheckBox checkHunter;
        private System.Windows.Forms.CheckBox checkPaladin;
    }
}