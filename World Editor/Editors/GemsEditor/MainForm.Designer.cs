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
            this.txtEffect1 = new System.Windows.Forms.TextBox();
            this.txtEffect2 = new System.Windows.Forms.TextBox();
            this.txtEffect3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.lstGems.Size = new System.Drawing.Size(207, 316);
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
            this.txtEnchantEntry.Location = new System.Drawing.Point(288, 19);
            this.txtEnchantEntry.Name = "txtEnchantEntry";
            this.txtEnchantEntry.Size = new System.Drawing.Size(69, 20);
            this.txtEnchantEntry.TabIndex = 9;
            // 
            // txtEnchantName
            // 
            this.txtEnchantName.Location = new System.Drawing.Point(53, 19);
            this.txtEnchantName.Name = "txtEnchantName";
            this.txtEnchantName.Size = new System.Drawing.Size(196, 20);
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
            this.label8.Location = new System.Drawing.Point(255, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID :";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(394, 203);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques";
            // 
            // txtMaxStatEnchant3
            // 
            this.txtMaxStatEnchant3.Location = new System.Drawing.Point(298, 138);
            this.txtMaxStatEnchant3.Name = "txtMaxStatEnchant3";
            this.txtMaxStatEnchant3.Size = new System.Drawing.Size(59, 20);
            this.txtMaxStatEnchant3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max stat 3 :";
            // 
            // txtMinStatEnchant3
            // 
            this.txtMinStatEnchant3.Location = new System.Drawing.Point(77, 138);
            this.txtMinStatEnchant3.Name = "txtMinStatEnchant3";
            this.txtMinStatEnchant3.Size = new System.Drawing.Size(59, 20);
            this.txtMinStatEnchant3.TabIndex = 9;
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
            this.txtMaxStatEnchant2.Location = new System.Drawing.Point(298, 75);
            this.txtMaxStatEnchant2.Name = "txtMaxStatEnchant2";
            this.txtMaxStatEnchant2.Size = new System.Drawing.Size(59, 20);
            this.txtMaxStatEnchant2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max stat 2 :";
            // 
            // txtMinStatEnchant2
            // 
            this.txtMinStatEnchant2.Location = new System.Drawing.Point(77, 75);
            this.txtMinStatEnchant2.Name = "txtMinStatEnchant2";
            this.txtMinStatEnchant2.Size = new System.Drawing.Size(59, 20);
            this.txtMinStatEnchant2.TabIndex = 5;
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
            this.txtMaxStatEnchant1.Location = new System.Drawing.Point(298, 17);
            this.txtMaxStatEnchant1.Name = "txtMaxStatEnchant1";
            this.txtMaxStatEnchant1.Size = new System.Drawing.Size(59, 20);
            this.txtMaxStatEnchant1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max stat 1 :";
            // 
            // txtMinStatEnchant1
            // 
            this.txtMinStatEnchant1.Location = new System.Drawing.Point(77, 17);
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
            // txtEffect1
            // 
            this.txtEffect1.Location = new System.Drawing.Point(77, 43);
            this.txtEffect1.Name = "txtEffect1";
            this.txtEffect1.Size = new System.Drawing.Size(215, 20);
            this.txtEffect1.TabIndex = 13;
            // 
            // txtEffect2
            // 
            this.txtEffect2.Location = new System.Drawing.Point(77, 101);
            this.txtEffect2.Name = "txtEffect2";
            this.txtEffect2.Size = new System.Drawing.Size(215, 20);
            this.txtEffect2.TabIndex = 14;
            // 
            // txtEffect3
            // 
            this.txtEffect3.Location = new System.Drawing.Point(77, 164);
            this.txtEffect3.Name = "txtEffect3";
            this.txtEffect3.Size = new System.Drawing.Size(215, 20);
            this.txtEffect3.TabIndex = 15;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Effet 2 :";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 339);
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
    }
}