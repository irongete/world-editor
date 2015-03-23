namespace World_Editor.GemsEditor
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
            this.lstGems = new System.Windows.Forms.ListBox();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.txtEnchantEntry = new System.Windows.Forms.TextBox();
            this.txtEnchantName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRequiredLevel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEffect3 = new System.Windows.Forms.TextBox();
            this.txtEffect2 = new System.Windows.Forms.TextBox();
            this.txtEffect1 = new System.Windows.Forms.TextBox();
            this.txtMaxStatEnchant3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinStatEnchant3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxStatEnchant2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinStatEnchant2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxStatEnchant1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinStatEnchant1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewEnchant = new System.Windows.Forms.Button();
            this.btnDelEnchant = new System.Windows.Forms.Button();
            this.btnSaveEnchant = new System.Windows.Forms.Button();
            this.txtSearchEnchant = new System.Windows.Forms.TextBox();
            this.btnEffect1Mask = new System.Windows.Forms.Button();
            this.btnEffect2Mask = new System.Windows.Forms.Button();
            this.btnEffect3Mask = new System.Windows.Forms.Button();
            this.grpInfos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGems
            // 
            this.lstGems.FormattingEnabled = true;
            this.lstGems.HorizontalScrollbar = true;
            this.lstGems.Location = new System.Drawing.Point(12, 12);
            this.lstGems.Name = "lstGems";
            this.lstGems.Size = new System.Drawing.Size(207, 368);
            this.lstGems.TabIndex = 0;
            this.lstGems.SelectedIndexChanged += new System.EventHandler(this.lstGems_SelectedIndexChanged);
            // 
            // grpInfos
            // 
            this.grpInfos.Controls.Add(this.txtEnchantEntry);
            this.grpInfos.Controls.Add(this.txtEnchantName);
            this.grpInfos.Controls.Add(this.label9);
            this.grpInfos.Controls.Add(this.label8);
            this.grpInfos.Location = new System.Drawing.Point(225, 12);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(394, 52);
            this.grpInfos.TabIndex = 7;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // txtEnchantEntry
            // 
            this.txtEnchantEntry.Enabled = false;
            this.txtEnchantEntry.Location = new System.Drawing.Point(332, 19);
            this.txtEnchantEntry.Name = "txtEnchantEntry";
            this.txtEnchantEntry.Size = new System.Drawing.Size(50, 20);
            this.txtEnchantEntry.TabIndex = 9;
            // 
            // txtEnchantName
            // 
            this.txtEnchantName.Location = new System.Drawing.Point(53, 19);
            this.txtEnchantName.Name = "txtEnchantName";
            this.txtEnchantName.Size = new System.Drawing.Size(238, 20);
            this.txtEnchantName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEffect3Mask);
            this.groupBox1.Controls.Add(this.btnEffect2Mask);
            this.groupBox1.Controls.Add(this.btnEffect1Mask);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtRequiredLevel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEffect3);
            this.groupBox1.Controls.Add(this.txtEffect2);
            this.groupBox1.Controls.Add(this.txtEffect1);
            this.groupBox1.Controls.Add(this.txtMaxStatEnchant3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMinStatEnchant3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaxStatEnchant2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMinStatEnchant2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaxStatEnchant1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMinStatEnchant1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(225, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 230);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques de l\'enchantement";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Meta",
            "Rouge",
            "Jaune",
            "Bleue"});
            this.comboBox1.Location = new System.Drawing.Point(232, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(164, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Chasse :";
            // 
            // txtRequiredLevel
            // 
            this.txtRequiredLevel.Location = new System.Drawing.Point(96, 190);
            this.txtRequiredLevel.Name = "txtRequiredLevel";
            this.txtRequiredLevel.Size = new System.Drawing.Size(59, 20);
            this.txtRequiredLevel.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Niveau requis :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Effet 3 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Effet 2 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Effet 1 :";
            // 
            // txtEffect3
            // 
            this.txtEffect3.Location = new System.Drawing.Point(96, 164);
            this.txtEffect3.Name = "txtEffect3";
            this.txtEffect3.Size = new System.Drawing.Size(215, 20);
            this.txtEffect3.TabIndex = 9;
            // 
            // txtEffect2
            // 
            this.txtEffect2.Location = new System.Drawing.Point(96, 103);
            this.txtEffect2.Name = "txtEffect2";
            this.txtEffect2.Size = new System.Drawing.Size(215, 20);
            this.txtEffect2.TabIndex = 6;
            // 
            // txtEffect1
            // 
            this.txtEffect1.Location = new System.Drawing.Point(96, 43);
            this.txtEffect1.Name = "txtEffect1";
            this.txtEffect1.Size = new System.Drawing.Size(215, 20);
            this.txtEffect1.TabIndex = 3;
            // 
            // txtMaxStatEnchant3
            // 
            this.txtMaxStatEnchant3.Location = new System.Drawing.Point(232, 138);
            this.txtMaxStatEnchant3.Name = "txtMaxStatEnchant3";
            this.txtMaxStatEnchant3.Size = new System.Drawing.Size(59, 20);
            this.txtMaxStatEnchant3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max stat 3 :";
            // 
            // txtMinStatEnchant3
            // 
            this.txtMinStatEnchant3.Location = new System.Drawing.Point(96, 138);
            this.txtMinStatEnchant3.Name = "txtMinStatEnchant3";
            this.txtMinStatEnchant3.Size = new System.Drawing.Size(59, 20);
            this.txtMinStatEnchant3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Min stat 3 :";
            // 
            // txtMaxStatEnchant2
            // 
            this.txtMaxStatEnchant2.Location = new System.Drawing.Point(232, 75);
            this.txtMaxStatEnchant2.Name = "txtMaxStatEnchant2";
            this.txtMaxStatEnchant2.Size = new System.Drawing.Size(59, 20);
            this.txtMaxStatEnchant2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max stat 2 :";
            // 
            // txtMinStatEnchant2
            // 
            this.txtMinStatEnchant2.Location = new System.Drawing.Point(96, 75);
            this.txtMinStatEnchant2.Name = "txtMinStatEnchant2";
            this.txtMinStatEnchant2.Size = new System.Drawing.Size(59, 20);
            this.txtMinStatEnchant2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min stat 2 :";
            // 
            // txtMaxStatEnchant1
            // 
            this.txtMaxStatEnchant1.Location = new System.Drawing.Point(232, 17);
            this.txtMaxStatEnchant1.Name = "txtMaxStatEnchant1";
            this.txtMaxStatEnchant1.Size = new System.Drawing.Size(59, 20);
            this.txtMaxStatEnchant1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max stat 1 :";
            // 
            // txtMinStatEnchant1
            // 
            this.txtMinStatEnchant1.Location = new System.Drawing.Point(96, 17);
            this.txtMinStatEnchant1.Name = "txtMinStatEnchant1";
            this.txtMinStatEnchant1.Size = new System.Drawing.Size(59, 20);
            this.txtMinStatEnchant1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min stat 1 :";
            // 
            // btnNewEnchant
            // 
            this.btnNewEnchant.Location = new System.Drawing.Point(240, 394);
            this.btnNewEnchant.Name = "btnNewEnchant";
            this.btnNewEnchant.Size = new System.Drawing.Size(139, 23);
            this.btnNewEnchant.TabIndex = 9;
            this.btnNewEnchant.Text = "Nouvel enchantement";
            this.btnNewEnchant.UseVisualStyleBackColor = true;
            this.btnNewEnchant.Click += new System.EventHandler(this.btnNewEnchant_Click);
            // 
            // btnDelEnchant
            // 
            this.btnDelEnchant.Location = new System.Drawing.Point(503, 395);
            this.btnDelEnchant.Name = "btnDelEnchant";
            this.btnDelEnchant.Size = new System.Drawing.Size(104, 23);
            this.btnDelEnchant.TabIndex = 10;
            this.btnDelEnchant.Text = "Supprimer";
            this.btnDelEnchant.UseVisualStyleBackColor = true;
            this.btnDelEnchant.Click += new System.EventHandler(this.btnDelEnchant_Click);
            // 
            // btnSaveEnchant
            // 
            this.btnSaveEnchant.Location = new System.Drawing.Point(392, 395);
            this.btnSaveEnchant.Name = "btnSaveEnchant";
            this.btnSaveEnchant.Size = new System.Drawing.Size(98, 23);
            this.btnSaveEnchant.TabIndex = 11;
            this.btnSaveEnchant.Text = "Sauvegarder";
            this.btnSaveEnchant.UseVisualStyleBackColor = true;
            this.btnSaveEnchant.Click += new System.EventHandler(this.btnSaveEnchant_Click);
            // 
            // txtSearchEnchant
            // 
            this.txtSearchEnchant.Location = new System.Drawing.Point(47, 394);
            this.txtSearchEnchant.Name = "txtSearchEnchant";
            this.txtSearchEnchant.Size = new System.Drawing.Size(172, 20);
            this.txtSearchEnchant.TabIndex = 12;
            this.txtSearchEnchant.TextChanged += new System.EventHandler(this.txtSearchEnchant_TextChanged);
            // 
            // btnEffect1Mask
            // 
            this.btnEffect1Mask.Location = new System.Drawing.Point(332, 43);
            this.btnEffect1Mask.Name = "btnEffect1Mask";
            this.btnEffect1Mask.Size = new System.Drawing.Size(21, 20);
            this.btnEffect1Mask.TabIndex = 22;
            this.btnEffect1Mask.Text = "+";
            this.btnEffect1Mask.UseVisualStyleBackColor = true;
            // 
            // btnEffect2Mask
            // 
            this.btnEffect2Mask.Location = new System.Drawing.Point(332, 103);
            this.btnEffect2Mask.Name = "btnEffect2Mask";
            this.btnEffect2Mask.Size = new System.Drawing.Size(21, 20);
            this.btnEffect2Mask.TabIndex = 23;
            this.btnEffect2Mask.Text = "+";
            this.btnEffect2Mask.UseVisualStyleBackColor = true;
            // 
            // btnEffect3Mask
            // 
            this.btnEffect3Mask.Location = new System.Drawing.Point(332, 164);
            this.btnEffect3Mask.Name = "btnEffect3Mask";
            this.btnEffect3Mask.Size = new System.Drawing.Size(21, 20);
            this.btnEffect3Mask.TabIndex = 24;
            this.btnEffect3Mask.Text = "+";
            this.btnEffect3Mask.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 429);
            this.Controls.Add(this.txtSearchEnchant);
            this.Controls.Add(this.btnSaveEnchant);
            this.Controls.Add(this.btnDelEnchant);
            this.Controls.Add(this.btnNewEnchant);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpInfos);
            this.Controls.Add(this.lstGems);
            this.Name = "MainForm";
            this.Text = "Gems Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGems;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.TextBox txtEnchantEntry;
        private System.Windows.Forms.TextBox txtEnchantName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaxStatEnchant3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinStatEnchant3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxStatEnchant2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinStatEnchant2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxStatEnchant1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinStatEnchant1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEffect3;
        private System.Windows.Forms.TextBox txtEffect2;
        private System.Windows.Forms.TextBox txtEffect1;
        private System.Windows.Forms.TextBox txtRequiredLevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNewEnchant;
        private System.Windows.Forms.Button btnDelEnchant;
        private System.Windows.Forms.Button btnSaveEnchant;
        private System.Windows.Forms.TextBox txtSearchEnchant;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEffect3Mask;
        private System.Windows.Forms.Button btnEffect2Mask;
        private System.Windows.Forms.Button btnEffect1Mask;
    }
}