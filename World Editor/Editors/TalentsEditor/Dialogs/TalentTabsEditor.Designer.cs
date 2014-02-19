namespace World_Editor.TalentsEditor.Dialogs
{
    partial class TalentTabsEditor
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
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPets = new System.Windows.Forms.TextBox();
            this.btnRaces = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClasses = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnPets = new System.Windows.Forms.Button();
            this.txtRaces = new System.Windows.Forms.TextBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.listOrder = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInternalName = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listTalentTab = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(280, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 22);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPets);
            this.groupBox1.Controls.Add(this.btnRaces);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtClasses);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnClasses);
            this.groupBox1.Controls.Add(this.btnPets);
            this.groupBox1.Controls.Add(this.txtRaces);
            this.groupBox1.Location = new System.Drawing.Point(165, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 103);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conditions";
            // 
            // txtPets
            // 
            this.txtPets.Location = new System.Drawing.Point(59, 71);
            this.txtPets.Name = "txtPets";
            this.txtPets.Size = new System.Drawing.Size(98, 20);
            this.txtPets.TabIndex = 7;
            this.txtPets.TextChanged += new System.EventHandler(this.txtPets_TextChanged);
            // 
            // btnRaces
            // 
            this.btnRaces.Location = new System.Drawing.Point(163, 17);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(22, 22);
            this.btnRaces.TabIndex = 23;
            this.btnRaces.Text = "+";
            this.btnRaces.UseVisualStyleBackColor = true;
            this.btnRaces.Click += new System.EventHandler(this.btnRaces_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Classes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Races";
            // 
            // txtClasses
            // 
            this.txtClasses.Location = new System.Drawing.Point(59, 45);
            this.txtClasses.Name = "txtClasses";
            this.txtClasses.Size = new System.Drawing.Size(98, 20);
            this.txtClasses.TabIndex = 8;
            this.txtClasses.TextChanged += new System.EventHandler(this.txtClasses_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Familiers";
            // 
            // btnClasses
            // 
            this.btnClasses.Location = new System.Drawing.Point(163, 43);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(22, 22);
            this.btnClasses.TabIndex = 21;
            this.btnClasses.Text = "+";
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnPets
            // 
            this.btnPets.Enabled = false;
            this.btnPets.Location = new System.Drawing.Point(163, 69);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(22, 22);
            this.btnPets.TabIndex = 22;
            this.btnPets.Text = "+";
            this.btnPets.UseVisualStyleBackColor = true;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
            // 
            // txtRaces
            // 
            this.txtRaces.Location = new System.Drawing.Point(59, 19);
            this.txtRaces.Name = "txtRaces";
            this.txtRaces.Size = new System.Drawing.Size(98, 20);
            this.txtRaces.TabIndex = 9;
            this.txtRaces.TextChanged += new System.EventHandler(this.txtRaces_TextChanged);
            // 
            // btnIcon
            // 
            this.btnIcon.Enabled = false;
            this.btnIcon.Location = new System.Drawing.Point(334, 41);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(22, 22);
            this.btnIcon.TabIndex = 39;
            this.btnIcon.Text = "+";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // listOrder
            // 
            this.listOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOrder.FormattingEnabled = true;
            this.listOrder.Items.AddRange(new object[] {
            "Onglet 1",
            "Onglet 2",
            "Onglet 3"});
            this.listOrder.Location = new System.Drawing.Point(271, 12);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(85, 21);
            this.listOrder.TabIndex = 38;
            this.listOrder.SelectedIndexChanged += new System.EventHandler(this.listOrder_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Icône";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ordre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nom interne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nom";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 33;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtInternalName
            // 
            this.txtInternalName.Location = new System.Drawing.Point(231, 69);
            this.txtInternalName.Name = "txtInternalName";
            this.txtInternalName.Size = new System.Drawing.Size(126, 20);
            this.txtInternalName.TabIndex = 32;
            this.txtInternalName.TextChanged += new System.EventHandler(this.txtInternalName_TextChanged);
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(232, 43);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(96, 20);
            this.txtIcon.TabIndex = 31;
            this.txtIcon.TextChanged += new System.EventHandler(this.txtIcon_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(184, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(42, 20);
            this.txtId.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Id";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(87, 230);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(69, 22);
            this.btnDel.TabIndex = 28;
            this.btnDel.Text = "Supprimer";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 22);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listTalentTab
            // 
            this.listTalentTab.FormattingEnabled = true;
            this.listTalentTab.Location = new System.Drawing.Point(12, 12);
            this.listTalentTab.Name = "listTalentTab";
            this.listTalentTab.Size = new System.Drawing.Size(144, 212);
            this.listTalentTab.TabIndex = 26;
            this.listTalentTab.SelectedIndexChanged += new System.EventHandler(this.listTalentTab_SelectedIndexChanged);
            // 
            // TalentTabsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 263);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInternalName);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listTalentTab);
            this.Name = "TalentTabsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editeur des onglets de talents";
            this.Load += new System.EventHandler(this.TalentTabsEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPets;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnPets;
        private System.Windows.Forms.TextBox txtRaces;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.ComboBox listOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInternalName;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listTalentTab;
    }
}