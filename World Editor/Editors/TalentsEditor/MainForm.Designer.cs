using World_Editor.Control;

namespace World_Editor.Editors.TalentsEditor
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
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkFlags = new System.Windows.Forms.CheckBox();
            this.txtPetFlags1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReqRank = new System.Windows.Forms.TextBox();
            this.txtPetFlags0 = new System.Windows.Forms.TextBox();
            this.txtReqTalent = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSpell4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSpell0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSpell1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpell2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpell3 = new System.Windows.Forms.TextBox();
            this.txtSpell4 = new System.Windows.Forms.TextBox();
            this.btnSpell3 = new System.Windows.Forms.Button();
            this.btnSpell0 = new System.Windows.Forms.Button();
            this.btnSpell2 = new System.Windows.Forms.Button();
            this.btnSpell1 = new System.Windows.Forms.Button();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.listTalents = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listTalentTab = new System.Windows.Forms.ComboBox();
            this.btnEditTalentTab = new System.Windows.Forms.Button();
            this.lblRenderTime = new System.Windows.Forms.Label();
            this.talentsUserControl = new World_Editor.Control.TalentsUserControl();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(97, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 22);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Sauvegarder les fichiers";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkFlags);
            this.groupBox2.Controls.Add(this.txtPetFlags1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtReqRank);
            this.groupBox2.Controls.Add(this.txtPetFlags0);
            this.groupBox2.Controls.Add(this.txtReqTalent);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtRow);
            this.groupBox2.Controls.Add(this.txtCol);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.listTalents);
            this.groupBox2.Location = new System.Drawing.Point(335, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 309);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Talents";
            // 
            // checkFlags
            // 
            this.checkFlags.AutoSize = true;
            this.checkFlags.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkFlags.Location = new System.Drawing.Point(111, 21);
            this.checkFlags.Name = "checkFlags";
            this.checkFlags.Size = new System.Drawing.Size(61, 17);
            this.checkFlags.TabIndex = 30;
            this.checkFlags.Text = "IsLearn";
            this.checkFlags.UseVisualStyleBackColor = true;
            // 
            // txtPetFlags1
            // 
            this.txtPetFlags1.Location = new System.Drawing.Point(123, 280);
            this.txtPetFlags1.Name = "txtPetFlags1";
            this.txtPetFlags1.Size = new System.Drawing.Size(26, 20);
            this.txtPetFlags1.TabIndex = 29;
            this.txtPetFlags1.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(6, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "PetFlags";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(6, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Rang requis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(6, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Talent requis";
            // 
            // txtReqRank
            // 
            this.txtReqRank.Location = new System.Drawing.Point(89, 254);
            this.txtReqRank.Name = "txtReqRank";
            this.txtReqRank.Size = new System.Drawing.Size(60, 20);
            this.txtReqRank.TabIndex = 24;
            this.txtReqRank.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // txtPetFlags0
            // 
            this.txtPetFlags0.Location = new System.Drawing.Point(89, 280);
            this.txtPetFlags0.Name = "txtPetFlags0";
            this.txtPetFlags0.Size = new System.Drawing.Size(28, 20);
            this.txtPetFlags0.TabIndex = 23;
            this.txtPetFlags0.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // txtReqTalent
            // 
            this.txtReqTalent.Location = new System.Drawing.Point(89, 228);
            this.txtReqTalent.Name = "txtReqTalent";
            this.txtReqTalent.Size = new System.Drawing.Size(60, 20);
            this.txtReqTalent.TabIndex = 21;
            this.txtReqTalent.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnSpell4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSpell0);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSpell1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSpell2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSpell3);
            this.groupBox3.Controls.Add(this.txtSpell4);
            this.groupBox3.Controls.Add(this.btnSpell3);
            this.groupBox3.Controls.Add(this.btnSpell0);
            this.groupBox3.Controls.Add(this.btnSpell2);
            this.groupBox3.Controls.Add(this.btnSpell1);
            this.groupBox3.Location = new System.Drawing.Point(9, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 151);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sorts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(15, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "#5";
            // 
            // btnSpell4
            // 
            this.btnSpell4.Enabled = false;
            this.btnSpell4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSpell4.Location = new System.Drawing.Point(129, 119);
            this.btnSpell4.Name = "btnSpell4";
            this.btnSpell4.Size = new System.Drawing.Size(22, 22);
            this.btnSpell4.TabIndex = 29;
            this.btnSpell4.Text = "+";
            this.btnSpell4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(15, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "#4";
            // 
            // txtSpell0
            // 
            this.txtSpell0.Location = new System.Drawing.Point(57, 17);
            this.txtSpell0.Name = "txtSpell0";
            this.txtSpell0.Size = new System.Drawing.Size(66, 20);
            this.txtSpell0.TabIndex = 20;
            this.txtSpell0.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "#3";
            // 
            // txtSpell1
            // 
            this.txtSpell1.Location = new System.Drawing.Point(57, 43);
            this.txtSpell1.Name = "txtSpell1";
            this.txtSpell1.Size = new System.Drawing.Size(66, 20);
            this.txtSpell1.TabIndex = 21;
            this.txtSpell1.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "#2";
            // 
            // txtSpell2
            // 
            this.txtSpell2.Location = new System.Drawing.Point(57, 69);
            this.txtSpell2.Name = "txtSpell2";
            this.txtSpell2.Size = new System.Drawing.Size(66, 20);
            this.txtSpell2.TabIndex = 22;
            this.txtSpell2.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "#1";
            // 
            // txtSpell3
            // 
            this.txtSpell3.Location = new System.Drawing.Point(57, 95);
            this.txtSpell3.Name = "txtSpell3";
            this.txtSpell3.Size = new System.Drawing.Size(66, 20);
            this.txtSpell3.TabIndex = 23;
            this.txtSpell3.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // txtSpell4
            // 
            this.txtSpell4.Location = new System.Drawing.Point(57, 121);
            this.txtSpell4.Name = "txtSpell4";
            this.txtSpell4.Size = new System.Drawing.Size(66, 20);
            this.txtSpell4.TabIndex = 24;
            this.txtSpell4.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // btnSpell3
            // 
            this.btnSpell3.Enabled = false;
            this.btnSpell3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSpell3.Location = new System.Drawing.Point(129, 93);
            this.btnSpell3.Name = "btnSpell3";
            this.btnSpell3.Size = new System.Drawing.Size(22, 22);
            this.btnSpell3.TabIndex = 28;
            this.btnSpell3.Text = "+";
            this.btnSpell3.UseVisualStyleBackColor = true;
            // 
            // btnSpell0
            // 
            this.btnSpell0.Enabled = false;
            this.btnSpell0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSpell0.Location = new System.Drawing.Point(129, 15);
            this.btnSpell0.Name = "btnSpell0";
            this.btnSpell0.Size = new System.Drawing.Size(22, 22);
            this.btnSpell0.TabIndex = 25;
            this.btnSpell0.Text = "+";
            this.btnSpell0.UseVisualStyleBackColor = true;
            // 
            // btnSpell2
            // 
            this.btnSpell2.Enabled = false;
            this.btnSpell2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSpell2.Location = new System.Drawing.Point(129, 67);
            this.btnSpell2.Name = "btnSpell2";
            this.btnSpell2.Size = new System.Drawing.Size(22, 22);
            this.btnSpell2.TabIndex = 27;
            this.btnSpell2.Text = "+";
            this.btnSpell2.UseVisualStyleBackColor = true;
            // 
            // btnSpell1
            // 
            this.btnSpell1.Enabled = false;
            this.btnSpell1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSpell1.Location = new System.Drawing.Point(129, 41);
            this.btnSpell1.Name = "btnSpell1";
            this.btnSpell1.Size = new System.Drawing.Size(22, 22);
            this.btnSpell1.TabIndex = 26;
            this.btnSpell1.Text = "+";
            this.btnSpell1.UseVisualStyleBackColor = true;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(40, 45);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(49, 20);
            this.txtRow.TabIndex = 19;
            this.txtRow.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(123, 45);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(49, 20);
            this.txtCol.TabIndex = 18;
            this.txtCol.TextChanged += new System.EventHandler(this.UpdateTalentTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(95, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Col";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Row";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(40, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(49, 20);
            this.txtId.TabIndex = 14;
            // 
            // listTalents
            // 
            this.listTalents.FormattingEnabled = true;
            this.listTalents.Location = new System.Drawing.Point(181, 19);
            this.listTalents.Name = "listTalents";
            this.listTalents.Size = new System.Drawing.Size(108, 277);
            this.listTalents.TabIndex = 11;
            this.listTalents.SelectedIndexChanged += new System.EventHandler(this.listTalents_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listTalentTab);
            this.groupBox1.Controls.Add(this.btnEditTalentTab);
            this.groupBox1.Location = new System.Drawing.Point(335, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 49);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbre de talents";
            // 
            // listTalentTab
            // 
            this.listTalentTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listTalentTab.FormattingEnabled = true;
            this.listTalentTab.Location = new System.Drawing.Point(6, 19);
            this.listTalentTab.Name = "listTalentTab";
            this.listTalentTab.Size = new System.Drawing.Size(225, 21);
            this.listTalentTab.TabIndex = 10;
            this.listTalentTab.SelectedIndexChanged += new System.EventHandler(this.listTalentTab_SelectedIndexChanged);
            // 
            // btnEditTalentTab
            // 
            this.btnEditTalentTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditTalentTab.Location = new System.Drawing.Point(237, 18);
            this.btnEditTalentTab.Name = "btnEditTalentTab";
            this.btnEditTalentTab.Size = new System.Drawing.Size(52, 22);
            this.btnEditTalentTab.TabIndex = 15;
            this.btnEditTalentTab.Text = "Editer";
            this.btnEditTalentTab.UseVisualStyleBackColor = true;
            this.btnEditTalentTab.Click += new System.EventHandler(this.btnEditTalentTab_Click);
            // 
            // lblRenderTime
            // 
            this.lblRenderTime.AutoSize = true;
            this.lblRenderTime.Location = new System.Drawing.Point(17, 358);
            this.lblRenderTime.Name = "lblRenderTime";
            this.lblRenderTime.Size = new System.Drawing.Size(75, 13);
            this.lblRenderTime.TabIndex = 24;
            this.lblRenderTime.Text = "lblRenderTime";
            // 
            // talentsUserControl
            // 
            this.talentsUserControl.Location = new System.Drawing.Point(12, 17);
            this.talentsUserControl.MaximumSize = new System.Drawing.Size(317, 330);
            this.talentsUserControl.MinimumSize = new System.Drawing.Size(317, 330);
            this.talentsUserControl.Name = "talentsUserControl";
            this.talentsUserControl.Size = new System.Drawing.Size(317, 330);
            this.talentsUserControl.TabIndex = 25;
            this.talentsUserControl.TalentSelectedEvent += new World_Editor.Control.TalentUserControlEventHandler(this.talentsUserControl_TalentSelectedEvent);
            this.talentsUserControl.TalentAddedEvent += new World_Editor.Control.TalentUserControlEventHandler(this.talentsUserControl_TalentAddedEvent);
            this.talentsUserControl.TalentDeletedEvent += new World_Editor.Control.TalentUserControlEventHandler(this.talentsUserControl_TalentDeletedEvent);
            this.talentsUserControl.ControlPaintTime += new World_Editor.Control.TalentUserControlEventHandler(this.talentsUserControl_ControlPaintTime);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 386);
            this.Controls.Add(this.talentsUserControl);
            this.Controls.Add(this.lblRenderTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editeur d\'abres de talents";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkFlags;
        private System.Windows.Forms.TextBox txtPetFlags1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReqRank;
        private System.Windows.Forms.TextBox txtPetFlags0;
        private System.Windows.Forms.TextBox txtReqTalent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSpell4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSpell0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSpell1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpell2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpell3;
        private System.Windows.Forms.TextBox txtSpell4;
        private System.Windows.Forms.Button btnSpell3;
        private System.Windows.Forms.Button btnSpell0;
        private System.Windows.Forms.Button btnSpell2;
        private System.Windows.Forms.Button btnSpell1;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ListBox listTalents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox listTalentTab;
        private System.Windows.Forms.Button btnEditTalentTab;
        private System.Windows.Forms.Label lblRenderTime;
        private TalentsUserControl talentsUserControl;
    }
}