namespace World_Editor.POIsEditor
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
            this.panelIn = new System.Windows.Forms.Panel();
            this.listWorldMapAreas = new System.Windows.Forms.ListBox();
            this.lblRenderTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNormalIcon = new System.Windows.Forms.TextBox();
            this.txtNormalIcon0 = new System.Windows.Forms.TextBox();
            this.txtNormalIcon50 = new System.Windows.Forms.TextBox();
            this.txtHordeIcon50 = new System.Windows.Forms.TextBox();
            this.txtHordeIcon0 = new System.Windows.Forms.TextBox();
            this.txtHordeIcon = new System.Windows.Forms.TextBox();
            this.txtAllianceIcon50 = new System.Windows.Forms.TextBox();
            this.txtAllianceIcon0 = new System.Windows.Forms.TextBox();
            this.txtAllianceIcon = new System.Windows.Forms.TextBox();
            this.btnIcons = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.txtWorldState = new System.Windows.Forms.TextBox();
            this.txtFactionId = new System.Windows.Forms.TextBox();
            this.txtImportance = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtContinentId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numLayer = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.listFaction = new System.Windows.Forms.ComboBox();
            this.barDestruct = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.listMaps = new System.Windows.Forms.ComboBox();
            this.listAreas = new System.Windows.Forms.ComboBox();
            this.btnFlags = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDestruct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIn
            // 
            this.panelIn.Location = new System.Drawing.Point(238, 12);
            this.panelIn.Name = "panelIn";
            this.panelIn.Size = new System.Drawing.Size(1002, 668);
            this.panelIn.TabIndex = 0;
            this.panelIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIn_Paint);
            this.panelIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelIn_MouseClick);
            this.panelIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIn_MouseDown);
            this.panelIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelIn_MouseMove);
            this.panelIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelIn_MouseUp);
            // 
            // listWorldMapAreas
            // 
            this.listWorldMapAreas.FormattingEnabled = true;
            this.listWorldMapAreas.Location = new System.Drawing.Point(12, 12);
            this.listWorldMapAreas.Name = "listWorldMapAreas";
            this.listWorldMapAreas.Size = new System.Drawing.Size(220, 225);
            this.listWorldMapAreas.TabIndex = 3;
            this.listWorldMapAreas.SelectedIndexChanged += new System.EventHandler(this.listMaps_SelectedIndexChanged);
            // 
            // lblRenderTime
            // 
            this.lblRenderTime.AutoSize = true;
            this.lblRenderTime.Location = new System.Drawing.Point(157, 667);
            this.lblRenderTime.Name = "lblRenderTime";
            this.lblRenderTime.Size = new System.Drawing.Size(75, 13);
            this.lblRenderTime.TabIndex = 4;
            this.lblRenderTime.Text = "lblRenderTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(31, 373);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 20);
            this.txtId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 347);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(113, 373);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(119, 20);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "50%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "100%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Alliance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Horde";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Normal";
            // 
            // txtNormalIcon
            // 
            this.txtNormalIcon.Location = new System.Drawing.Point(49, 26);
            this.txtNormalIcon.Name = "txtNormalIcon";
            this.txtNormalIcon.Size = new System.Drawing.Size(39, 20);
            this.txtNormalIcon.TabIndex = 18;
            this.txtNormalIcon.TextChanged += new System.EventHandler(this.txtNormalIcon_TextChanged);
            // 
            // txtNormalIcon0
            // 
            this.txtNormalIcon0.Location = new System.Drawing.Point(139, 26);
            this.txtNormalIcon0.Name = "txtNormalIcon0";
            this.txtNormalIcon0.Size = new System.Drawing.Size(39, 20);
            this.txtNormalIcon0.TabIndex = 19;
            this.txtNormalIcon0.TextChanged += new System.EventHandler(this.txtNormalIcon0_TextChanged);
            // 
            // txtNormalIcon50
            // 
            this.txtNormalIcon50.Location = new System.Drawing.Point(94, 26);
            this.txtNormalIcon50.Name = "txtNormalIcon50";
            this.txtNormalIcon50.Size = new System.Drawing.Size(39, 20);
            this.txtNormalIcon50.TabIndex = 20;
            this.txtNormalIcon50.TextChanged += new System.EventHandler(this.txtNormalIcon50_TextChanged);
            // 
            // txtHordeIcon50
            // 
            this.txtHordeIcon50.Location = new System.Drawing.Point(94, 52);
            this.txtHordeIcon50.Name = "txtHordeIcon50";
            this.txtHordeIcon50.Size = new System.Drawing.Size(39, 20);
            this.txtHordeIcon50.TabIndex = 23;
            this.txtHordeIcon50.TextChanged += new System.EventHandler(this.txtHordeIcon50_TextChanged);
            // 
            // txtHordeIcon0
            // 
            this.txtHordeIcon0.Location = new System.Drawing.Point(139, 52);
            this.txtHordeIcon0.Name = "txtHordeIcon0";
            this.txtHordeIcon0.Size = new System.Drawing.Size(39, 20);
            this.txtHordeIcon0.TabIndex = 22;
            this.txtHordeIcon0.TextChanged += new System.EventHandler(this.txtHordeIcon0_TextChanged);
            // 
            // txtHordeIcon
            // 
            this.txtHordeIcon.Location = new System.Drawing.Point(49, 52);
            this.txtHordeIcon.Name = "txtHordeIcon";
            this.txtHordeIcon.Size = new System.Drawing.Size(39, 20);
            this.txtHordeIcon.TabIndex = 21;
            this.txtHordeIcon.TextChanged += new System.EventHandler(this.txtHordeIcon_TextChanged);
            // 
            // txtAllianceIcon50
            // 
            this.txtAllianceIcon50.Location = new System.Drawing.Point(94, 78);
            this.txtAllianceIcon50.Name = "txtAllianceIcon50";
            this.txtAllianceIcon50.Size = new System.Drawing.Size(39, 20);
            this.txtAllianceIcon50.TabIndex = 26;
            this.txtAllianceIcon50.TextChanged += new System.EventHandler(this.txtAllianceIcon50_TextChanged);
            // 
            // txtAllianceIcon0
            // 
            this.txtAllianceIcon0.Location = new System.Drawing.Point(139, 78);
            this.txtAllianceIcon0.Name = "txtAllianceIcon0";
            this.txtAllianceIcon0.Size = new System.Drawing.Size(39, 20);
            this.txtAllianceIcon0.TabIndex = 25;
            this.txtAllianceIcon0.TextChanged += new System.EventHandler(this.txtAllianceIcon0_TextChanged);
            // 
            // txtAllianceIcon
            // 
            this.txtAllianceIcon.Location = new System.Drawing.Point(49, 78);
            this.txtAllianceIcon.Name = "txtAllianceIcon";
            this.txtAllianceIcon.Size = new System.Drawing.Size(39, 20);
            this.txtAllianceIcon.TabIndex = 24;
            this.txtAllianceIcon.TextChanged += new System.EventHandler(this.txtAllianceIcon_TextChanged);
            // 
            // btnIcons
            // 
            this.btnIcons.Location = new System.Drawing.Point(184, 23);
            this.btnIcons.Name = "btnIcons";
            this.btnIcons.Size = new System.Drawing.Size(23, 75);
            this.btnIcons.TabIndex = 27;
            this.btnIcons.Text = "Icons";
            this.btnIcons.UseVisualStyleBackColor = true;
            this.btnIcons.Click += new System.EventHandler(this.btnIcons_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnIcons);
            this.groupBox1.Controls.Add(this.txtAllianceIcon50);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAllianceIcon0);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAllianceIcon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHordeIcon50);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtHordeIcon0);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtHordeIcon);
            this.groupBox1.Controls.Add(this.txtNormalIcon);
            this.groupBox1.Controls.Add(this.txtNormalIcon50);
            this.groupBox1.Controls.Add(this.txtNormalIcon0);
            this.groupBox1.Location = new System.Drawing.Point(15, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 104);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icons";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(98, 509);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(50, 20);
            this.txtX.TabIndex = 28;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(176, 509);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(50, 20);
            this.txtZ.TabIndex = 32;
            this.txtZ.TextChanged += new System.EventHandler(this.txtZ_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Z";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(23, 509);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(50, 20);
            this.txtY.TabIndex = 31;
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 590);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Importance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 616);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "WorldState";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 564);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "AreaId";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 538);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "MapId";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(124, 590);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Flags";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(124, 616);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "FactionId";
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(162, 587);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(42, 20);
            this.txtFlags.TabIndex = 38;
            this.txtFlags.TextChanged += new System.EventHandler(this.txtFlags_TextChanged);
            // 
            // txtWorldState
            // 
            this.txtWorldState.Location = new System.Drawing.Point(79, 613);
            this.txtWorldState.Name = "txtWorldState";
            this.txtWorldState.Size = new System.Drawing.Size(39, 20);
            this.txtWorldState.TabIndex = 39;
            this.txtWorldState.TextChanged += new System.EventHandler(this.txtWorldState_TextChanged);
            // 
            // txtFactionId
            // 
            this.txtFactionId.Location = new System.Drawing.Point(176, 613);
            this.txtFactionId.Name = "txtFactionId";
            this.txtFactionId.Size = new System.Drawing.Size(56, 20);
            this.txtFactionId.TabIndex = 40;
            this.txtFactionId.TextChanged += new System.EventHandler(this.txtFactionId_TextChanged);
            // 
            // txtImportance
            // 
            this.txtImportance.Location = new System.Drawing.Point(79, 587);
            this.txtImportance.Name = "txtImportance";
            this.txtImportance.Size = new System.Drawing.Size(39, 20);
            this.txtImportance.TabIndex = 41;
            this.txtImportance.TextChanged += new System.EventHandler(this.txtImportance_TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(55, 561);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(39, 20);
            this.txtArea.TabIndex = 42;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtContinentId
            // 
            this.txtContinentId.Location = new System.Drawing.Point(55, 535);
            this.txtContinentId.Name = "txtContinentId";
            this.txtContinentId.Size = new System.Drawing.Size(39, 20);
            this.txtContinentId.TabIndex = 43;
            this.txtContinentId.TextChanged += new System.EventHandler(this.txtContinentId_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numLayer);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.listFaction);
            this.groupBox3.Controls.Add(this.barDestruct);
            this.groupBox3.Location = new System.Drawing.Point(12, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 90);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display Options";
            // 
            // numLayer
            // 
            this.numLayer.Enabled = false;
            this.numLayer.Location = new System.Drawing.Point(169, 63);
            this.numLayer.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayer.Name = "numLayer";
            this.numLayer.Size = new System.Drawing.Size(45, 20);
            this.numLayer.TabIndex = 6;
            this.numLayer.ValueChanged += new System.EventHandler(this.numLayer_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(130, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Layer";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(98, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "50%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "0%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(181, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "100%";
            // 
            // listFaction
            // 
            this.listFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listFaction.FormattingEnabled = true;
            this.listFaction.Items.AddRange(new object[] {
            "Normal",
            "Horde",
            "Alliance"});
            this.listFaction.Location = new System.Drawing.Point(8, 63);
            this.listFaction.Name = "listFaction";
            this.listFaction.Size = new System.Drawing.Size(117, 21);
            this.listFaction.TabIndex = 1;
            this.listFaction.SelectedIndexChanged += new System.EventHandler(this.listFaction_SelectedIndexChanged);
            // 
            // barDestruct
            // 
            this.barDestruct.Cursor = System.Windows.Forms.Cursors.Default;
            this.barDestruct.Location = new System.Drawing.Point(6, 19);
            this.barDestruct.Maximum = 2;
            this.barDestruct.Name = "barDestruct";
            this.barDestruct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barDestruct.Size = new System.Drawing.Size(208, 45);
            this.barDestruct.TabIndex = 0;
            this.barDestruct.Value = 2;
            this.barDestruct.Scroll += new System.EventHandler(this.barDestruct_Scroll);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(76, 376);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "Desc.";
            // 
            // listMaps
            // 
            this.listMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMaps.FormattingEnabled = true;
            this.listMaps.Location = new System.Drawing.Point(100, 534);
            this.listMaps.Name = "listMaps";
            this.listMaps.Size = new System.Drawing.Size(132, 21);
            this.listMaps.TabIndex = 46;
            this.listMaps.SelectedIndexChanged += new System.EventHandler(this.listMaps_SelectedIndexChanged_1);
            // 
            // listAreas
            // 
            this.listAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listAreas.FormattingEnabled = true;
            this.listAreas.Location = new System.Drawing.Point(100, 561);
            this.listAreas.Name = "listAreas";
            this.listAreas.Size = new System.Drawing.Size(132, 21);
            this.listAreas.TabIndex = 47;
            this.listAreas.SelectedIndexChanged += new System.EventHandler(this.listAreas_SelectedIndexChanged);
            // 
            // btnFlags
            // 
            this.btnFlags.Location = new System.Drawing.Point(210, 585);
            this.btnFlags.Name = "btnFlags";
            this.btnFlags.Size = new System.Drawing.Size(22, 22);
            this.btnFlags.TabIndex = 48;
            this.btnFlags.Text = "+";
            this.btnFlags.UseVisualStyleBackColor = true;
            this.btnFlags.Click += new System.EventHandler(this.btnFlags_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 642);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 22);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 686);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFlags);
            this.Controls.Add(this.listAreas);
            this.Controls.Add(this.listMaps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtContinentId);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtImportance);
            this.Controls.Add(this.txtFactionId);
            this.Controls.Add(this.txtWorldState);
            this.Controls.Add(this.txtFlags);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRenderTime);
            this.Controls.Add(this.panelIn);
            this.Controls.Add(this.listWorldMapAreas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Points of Interest Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDestruct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIn;
        private System.Windows.Forms.ListBox listWorldMapAreas;
        private System.Windows.Forms.Label lblRenderTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNormalIcon;
        private System.Windows.Forms.TextBox txtNormalIcon0;
        private System.Windows.Forms.TextBox txtNormalIcon50;
        private System.Windows.Forms.TextBox txtHordeIcon50;
        private System.Windows.Forms.TextBox txtHordeIcon0;
        private System.Windows.Forms.TextBox txtHordeIcon;
        private System.Windows.Forms.TextBox txtAllianceIcon50;
        private System.Windows.Forms.TextBox txtAllianceIcon0;
        private System.Windows.Forms.TextBox txtAllianceIcon;
        private System.Windows.Forms.Button btnIcons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.TextBox txtWorldState;
        private System.Windows.Forms.TextBox txtFactionId;
        private System.Windows.Forms.TextBox txtImportance;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtContinentId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox listFaction;
        private System.Windows.Forms.TrackBar barDestruct;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numLayer;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox listMaps;
        private System.Windows.Forms.ComboBox listAreas;
        private System.Windows.Forms.Button btnFlags;
        private System.Windows.Forms.Button btnSave;
    }
}