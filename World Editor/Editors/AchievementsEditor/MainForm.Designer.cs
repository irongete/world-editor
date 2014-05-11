using World_Editor.Control;
using World_Editor.Utils;

namespace World_Editor.Editors.AchievementsEditor
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
            this.components = new System.ComponentModel.Container();
            this.treeAchievements = new System.Windows.Forms.TreeView();
            this.lblTimeRender = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.btnAchAdd = new System.Windows.Forms.Button();
            this.tabAchievement = new System.Windows.Forms.TabControl();
            this.tabPageAchievement = new System.Windows.Forms.TabPage();
            this.btnReconstructTree = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtAchievementRef = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panelRenderAchievement = new World_Editor.Control.AchievementPanel(this.components);
            this.groupBoxCriterias = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCriteriaFlags = new System.Windows.Forms.TextBox();
            this.txtTimeLimit = new System.Windows.Forms.TextBox();
            this.txtTimedType = new System.Windows.Forms.TextBox();
            this.txtTimerStartEvent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblReqType1 = new System.Windows.Forms.Label();
            this.lblReqType2 = new System.Windows.Forms.Label();
            this.lblReqValue2 = new System.Windows.Forms.Label();
            this.lblReqValue1 = new System.Windows.Forms.Label();
            this.txtReqValue1 = new System.Windows.Forms.TextBox();
            this.txtReqValue2 = new System.Windows.Forms.TextBox();
            this.txtReqType1 = new System.Windows.Forms.TextBox();
            this.txtReqType2 = new System.Windows.Forms.TextBox();
            this.txtReqValue0 = new System.Windows.Forms.TextBox();
            this.listCriteriaType = new System.Windows.Forms.ComboBox();
            this.txtCriteriaOrder = new System.Windows.Forms.TextBox();
            this.txtCriteriaName = new System.Windows.Forms.TextBox();
            this.txtCriteriaAchievement = new System.Windows.Forms.TextBox();
            this.txtReqType0 = new System.Windows.Forms.TextBox();
            this.txtCriteriaId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblReqType0 = new System.Windows.Forms.Label();
            this.lblReqValue0 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRmvCriteria = new System.Windows.Forms.Button();
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.listCriterias = new System.Windows.Forms.ListBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.btnFlags = new System.Windows.Forms.Button();
            this.txtParentAchievement = new System.Windows.Forms.TextBox();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listMap = new System.Windows.Forms.ComboBox();
            this.listFaction = new System.Windows.Forms.ComboBox();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCatParentId = new System.Windows.Forms.Label();
            this.txtCatOrder = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCatParentId = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabAchievement.SuspendLayout();
            this.tabPageAchievement.SuspendLayout();
            this.groupBoxCriterias.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeAchievements
            // 
            this.treeAchievements.Location = new System.Drawing.Point(12, 12);
            this.treeAchievements.Name = "treeAchievements";
            this.treeAchievements.Size = new System.Drawing.Size(222, 454);
            this.treeAchievements.TabIndex = 0;
            this.treeAchievements.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeAchievements_AfterSelect);
            // 
            // lblTimeRender
            // 
            this.lblTimeRender.AutoSize = true;
            this.lblTimeRender.Location = new System.Drawing.Point(12, 525);
            this.lblTimeRender.Name = "lblTimeRender";
            this.lblTimeRender.Size = new System.Drawing.Size(75, 13);
            this.lblTimeRender.TabIndex = 1;
            this.lblTimeRender.Text = "lblTimeRender";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(25, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 20);
            this.txtId.TabIndex = 2;
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Location = new System.Drawing.Point(12, 472);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(108, 22);
            this.btnCatAdd.TabIndex = 3;
            this.btnCatAdd.Text = "Add category";
            this.btnCatAdd.UseVisualStyleBackColor = true;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // btnAchAdd
            // 
            this.btnAchAdd.Location = new System.Drawing.Point(126, 472);
            this.btnAchAdd.Name = "btnAchAdd";
            this.btnAchAdd.Size = new System.Drawing.Size(108, 22);
            this.btnAchAdd.TabIndex = 4;
            this.btnAchAdd.Text = "Add achievement";
            this.btnAchAdd.UseVisualStyleBackColor = true;
            this.btnAchAdd.Click += new System.EventHandler(this.btnAchAdd_Click);
            // 
            // tabAchievement
            // 
            this.tabAchievement.Controls.Add(this.tabPageAchievement);
            this.tabAchievement.Controls.Add(this.tabPageCategory);
            this.tabAchievement.Location = new System.Drawing.Point(240, 12);
            this.tabAchievement.Name = "tabAchievement";
            this.tabAchievement.SelectedIndex = 0;
            this.tabAchievement.Size = new System.Drawing.Size(488, 519);
            this.tabAchievement.TabIndex = 5;
            this.tabAchievement.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabAchievement_Selecting);
            // 
            // tabPageAchievement
            // 
            this.tabPageAchievement.Controls.Add(this.btnReconstructTree);
            this.tabPageAchievement.Controls.Add(this.txtCount);
            this.tabPageAchievement.Controls.Add(this.txtAchievementRef);
            this.tabPageAchievement.Controls.Add(this.label23);
            this.tabPageAchievement.Controls.Add(this.label22);
            this.tabPageAchievement.Controls.Add(this.panelRenderAchievement);
            this.tabPageAchievement.Controls.Add(this.groupBoxCriterias);
            this.tabPageAchievement.Controls.Add(this.btnIcon);
            this.tabPageAchievement.Controls.Add(this.btnFlags);
            this.tabPageAchievement.Controls.Add(this.txtParentAchievement);
            this.tabPageAchievement.Controls.Add(this.txtReward);
            this.tabPageAchievement.Controls.Add(this.txtPoints);
            this.tabPageAchievement.Controls.Add(this.txtOrder);
            this.tabPageAchievement.Controls.Add(this.txtFlags);
            this.tabPageAchievement.Controls.Add(this.txtCategory);
            this.tabPageAchievement.Controls.Add(this.txtIcon);
            this.tabPageAchievement.Controls.Add(this.txtDescription);
            this.tabPageAchievement.Controls.Add(this.txtName);
            this.tabPageAchievement.Controls.Add(this.listMap);
            this.tabPageAchievement.Controls.Add(this.listFaction);
            this.tabPageAchievement.Controls.Add(this.txtMap);
            this.tabPageAchievement.Controls.Add(this.label12);
            this.tabPageAchievement.Controls.Add(this.label11);
            this.tabPageAchievement.Controls.Add(this.label10);
            this.tabPageAchievement.Controls.Add(this.label9);
            this.tabPageAchievement.Controls.Add(this.label8);
            this.tabPageAchievement.Controls.Add(this.label7);
            this.tabPageAchievement.Controls.Add(this.label6);
            this.tabPageAchievement.Controls.Add(this.label5);
            this.tabPageAchievement.Controls.Add(this.label4);
            this.tabPageAchievement.Controls.Add(this.label3);
            this.tabPageAchievement.Controls.Add(this.label2);
            this.tabPageAchievement.Controls.Add(this.label1);
            this.tabPageAchievement.Controls.Add(this.txtId);
            this.tabPageAchievement.Location = new System.Drawing.Point(4, 22);
            this.tabPageAchievement.Name = "tabPageAchievement";
            this.tabPageAchievement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAchievement.Size = new System.Drawing.Size(480, 493);
            this.tabPageAchievement.TabIndex = 0;
            this.tabPageAchievement.Text = "Achievement";
            this.tabPageAchievement.UseVisualStyleBackColor = true;
            // 
            // btnReconstructTree
            // 
            this.btnReconstructTree.Location = new System.Drawing.Point(314, 136);
            this.btnReconstructTree.Name = "btnReconstructTree";
            this.btnReconstructTree.Size = new System.Drawing.Size(22, 22);
            this.btnReconstructTree.TabIndex = 8;
            this.btnReconstructTree.Text = "\t↩";
            this.btnReconstructTree.UseVisualStyleBackColor = true;
            this.btnReconstructTree.Click += new System.EventHandler(this.btnReconstructTree_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(419, 137);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(55, 20);
            this.txtCount.TabIndex = 34;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // txtAchievementRef
            // 
            this.txtAchievementRef.Location = new System.Drawing.Point(326, 162);
            this.txtAchievementRef.Name = "txtAchievementRef";
            this.txtAchievementRef.Size = new System.Drawing.Size(52, 20);
            this.txtAchievementRef.TabIndex = 33;
            this.txtAchievementRef.TextChanged += new System.EventHandler(this.txtAchievementRef_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(203, 165);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Achievement reference";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(351, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Criterias req";
            // 
            // panelRenderAchievement
            // 
            this.panelRenderAchievement.Location = new System.Drawing.Point(84, 400);
            this.panelRenderAchievement.Name = "panelRenderAchievement";
            this.panelRenderAchievement.Size = new System.Drawing.Size(310, 87);
            this.panelRenderAchievement.TabIndex = 30;
            // 
            // groupBoxCriterias
            // 
            this.groupBoxCriterias.Controls.Add(this.label21);
            this.groupBoxCriterias.Controls.Add(this.label20);
            this.groupBoxCriterias.Controls.Add(this.label15);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaFlags);
            this.groupBoxCriterias.Controls.Add(this.txtTimeLimit);
            this.groupBoxCriterias.Controls.Add(this.txtTimedType);
            this.groupBoxCriterias.Controls.Add(this.txtTimerStartEvent);
            this.groupBoxCriterias.Controls.Add(this.label14);
            this.groupBoxCriterias.Controls.Add(this.lblReqType1);
            this.groupBoxCriterias.Controls.Add(this.lblReqType2);
            this.groupBoxCriterias.Controls.Add(this.lblReqValue2);
            this.groupBoxCriterias.Controls.Add(this.lblReqValue1);
            this.groupBoxCriterias.Controls.Add(this.txtReqValue1);
            this.groupBoxCriterias.Controls.Add(this.txtReqValue2);
            this.groupBoxCriterias.Controls.Add(this.txtReqType1);
            this.groupBoxCriterias.Controls.Add(this.txtReqType2);
            this.groupBoxCriterias.Controls.Add(this.txtReqValue0);
            this.groupBoxCriterias.Controls.Add(this.listCriteriaType);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaOrder);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaName);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaAchievement);
            this.groupBoxCriterias.Controls.Add(this.txtReqType0);
            this.groupBoxCriterias.Controls.Add(this.txtCriteriaId);
            this.groupBoxCriterias.Controls.Add(this.label19);
            this.groupBoxCriterias.Controls.Add(this.label18);
            this.groupBoxCriterias.Controls.Add(this.label17);
            this.groupBoxCriterias.Controls.Add(this.label16);
            this.groupBoxCriterias.Controls.Add(this.lblReqType0);
            this.groupBoxCriterias.Controls.Add(this.lblReqValue0);
            this.groupBoxCriterias.Controls.Add(this.label13);
            this.groupBoxCriterias.Controls.Add(this.btnRmvCriteria);
            this.groupBoxCriterias.Controls.Add(this.btnAddCriteria);
            this.groupBoxCriterias.Controls.Add(this.listCriterias);
            this.groupBoxCriterias.Location = new System.Drawing.Point(9, 188);
            this.groupBoxCriterias.Name = "groupBoxCriterias";
            this.groupBoxCriterias.Size = new System.Drawing.Size(465, 206);
            this.groupBoxCriterias.TabIndex = 29;
            this.groupBoxCriterias.TabStop = false;
            this.groupBoxCriterias.Text = "Criterias";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(336, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "timedType";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(312, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "timerStartEvent";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(116, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "TimeLimit";
            // 
            // txtCriteriaFlags
            // 
            this.txtCriteriaFlags.Location = new System.Drawing.Point(396, 19);
            this.txtCriteriaFlags.Name = "txtCriteriaFlags";
            this.txtCriteriaFlags.Size = new System.Drawing.Size(60, 20);
            this.txtCriteriaFlags.TabIndex = 29;
            this.txtCriteriaFlags.TextChanged += new System.EventHandler(this.txtCriteriaFlags_TextChanged);
            // 
            // txtTimeLimit
            // 
            this.txtTimeLimit.Location = new System.Drawing.Point(173, 97);
            this.txtTimeLimit.Name = "txtTimeLimit";
            this.txtTimeLimit.Size = new System.Drawing.Size(41, 20);
            this.txtTimeLimit.TabIndex = 28;
            this.txtTimeLimit.TextChanged += new System.EventHandler(this.txtTimeLimit_TextChanged);
            // 
            // txtTimedType
            // 
            this.txtTimedType.Location = new System.Drawing.Point(396, 97);
            this.txtTimedType.Name = "txtTimedType";
            this.txtTimedType.Size = new System.Drawing.Size(60, 20);
            this.txtTimedType.TabIndex = 27;
            this.txtTimedType.TextChanged += new System.EventHandler(this.txtTimedType_TextChanged);
            // 
            // txtTimerStartEvent
            // 
            this.txtTimerStartEvent.Location = new System.Drawing.Point(396, 71);
            this.txtTimerStartEvent.Name = "txtTimerStartEvent";
            this.txtTimerStartEvent.Size = new System.Drawing.Size(60, 20);
            this.txtTimerStartEvent.TabIndex = 26;
            this.txtTimerStartEvent.TextChanged += new System.EventHandler(this.txtTimerStartEvent_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Completion flag";
            // 
            // lblReqType1
            // 
            this.lblReqType1.Location = new System.Drawing.Point(116, 155);
            this.lblReqType1.Name = "lblReqType1";
            this.lblReqType1.Size = new System.Drawing.Size(108, 20);
            this.lblReqType1.TabIndex = 24;
            this.lblReqType1.Text = "lblReqType1";
            this.lblReqType1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqType2
            // 
            this.lblReqType2.Location = new System.Drawing.Point(116, 181);
            this.lblReqType2.Name = "lblReqType2";
            this.lblReqType2.Size = new System.Drawing.Size(109, 20);
            this.lblReqType2.TabIndex = 23;
            this.lblReqType2.Text = "lblReqType2";
            this.lblReqType2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqValue2
            // 
            this.lblReqValue2.Location = new System.Drawing.Point(292, 181);
            this.lblReqValue2.Name = "lblReqValue2";
            this.lblReqValue2.Size = new System.Drawing.Size(106, 20);
            this.lblReqValue2.TabIndex = 22;
            this.lblReqValue2.Text = "lblReqValue2";
            this.lblReqValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqValue1
            // 
            this.lblReqValue1.Location = new System.Drawing.Point(292, 155);
            this.lblReqValue1.Name = "lblReqValue1";
            this.lblReqValue1.Size = new System.Drawing.Size(106, 20);
            this.lblReqValue1.TabIndex = 21;
            this.lblReqValue1.Text = "lblReqValue1";
            this.lblReqValue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReqValue1
            // 
            this.txtReqValue1.Location = new System.Drawing.Point(404, 155);
            this.txtReqValue1.Name = "txtReqValue1";
            this.txtReqValue1.Size = new System.Drawing.Size(55, 20);
            this.txtReqValue1.TabIndex = 20;
            this.txtReqValue1.TextChanged += new System.EventHandler(this.txtReqValue1_TextChanged);
            // 
            // txtReqValue2
            // 
            this.txtReqValue2.Location = new System.Drawing.Point(404, 181);
            this.txtReqValue2.Name = "txtReqValue2";
            this.txtReqValue2.Size = new System.Drawing.Size(55, 20);
            this.txtReqValue2.TabIndex = 19;
            this.txtReqValue2.TextChanged += new System.EventHandler(this.txtReqValue2_TextChanged);
            // 
            // txtReqType1
            // 
            this.txtReqType1.Location = new System.Drawing.Point(230, 155);
            this.txtReqType1.Name = "txtReqType1";
            this.txtReqType1.Size = new System.Drawing.Size(56, 20);
            this.txtReqType1.TabIndex = 18;
            this.txtReqType1.TextChanged += new System.EventHandler(this.txtReqType1_TextChanged);
            // 
            // txtReqType2
            // 
            this.txtReqType2.Location = new System.Drawing.Point(231, 181);
            this.txtReqType2.Name = "txtReqType2";
            this.txtReqType2.Size = new System.Drawing.Size(55, 20);
            this.txtReqType2.TabIndex = 17;
            this.txtReqType2.TextChanged += new System.EventHandler(this.txtReqType2_TextChanged);
            // 
            // txtReqValue0
            // 
            this.txtReqValue0.Location = new System.Drawing.Point(404, 129);
            this.txtReqValue0.Name = "txtReqValue0";
            this.txtReqValue0.Size = new System.Drawing.Size(55, 20);
            this.txtReqValue0.TabIndex = 16;
            this.txtReqValue0.TextChanged += new System.EventHandler(this.txtReqValue0_TextChanged);
            // 
            // listCriteriaType
            // 
            this.listCriteriaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCriteriaType.FormattingEnabled = true;
            this.listCriteriaType.Location = new System.Drawing.Point(173, 45);
            this.listCriteriaType.Name = "listCriteriaType";
            this.listCriteriaType.Size = new System.Drawing.Size(283, 21);
            this.listCriteriaType.TabIndex = 15;
            this.listCriteriaType.SelectedIndexChanged += new System.EventHandler(this.listCriteriaType_SelectedIndexChanged);
            // 
            // txtCriteriaOrder
            // 
            this.txtCriteriaOrder.Location = new System.Drawing.Point(291, 97);
            this.txtCriteriaOrder.Name = "txtCriteriaOrder";
            this.txtCriteriaOrder.Size = new System.Drawing.Size(39, 20);
            this.txtCriteriaOrder.TabIndex = 14;
            this.txtCriteriaOrder.TextChanged += new System.EventHandler(this.txtCriteriaOrder_TextChanged);
            // 
            // txtCriteriaName
            // 
            this.txtCriteriaName.Location = new System.Drawing.Point(173, 72);
            this.txtCriteriaName.Name = "txtCriteriaName";
            this.txtCriteriaName.Size = new System.Drawing.Size(131, 20);
            this.txtCriteriaName.TabIndex = 13;
            this.txtCriteriaName.TextChanged += new System.EventHandler(this.txtCriteriaName_TextChanged);
            // 
            // txtCriteriaAchievement
            // 
            this.txtCriteriaAchievement.Enabled = false;
            this.txtCriteriaAchievement.Location = new System.Drawing.Point(260, 19);
            this.txtCriteriaAchievement.Name = "txtCriteriaAchievement";
            this.txtCriteriaAchievement.Size = new System.Drawing.Size(44, 20);
            this.txtCriteriaAchievement.TabIndex = 12;
            // 
            // txtReqType0
            // 
            this.txtReqType0.Location = new System.Drawing.Point(231, 129);
            this.txtReqType0.Name = "txtReqType0";
            this.txtReqType0.Size = new System.Drawing.Size(55, 20);
            this.txtReqType0.TabIndex = 11;
            this.txtReqType0.TextChanged += new System.EventHandler(this.txtReqType0_TextChanged);
            // 
            // txtCriteriaId
            // 
            this.txtCriteriaId.Enabled = false;
            this.txtCriteriaId.Location = new System.Drawing.Point(138, 19);
            this.txtCriteriaId.Name = "txtCriteriaId";
            this.txtCriteriaId.Size = new System.Drawing.Size(41, 20);
            this.txtCriteriaId.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(185, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Achievement";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(220, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "CriteriaOrder";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(116, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(116, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Name";
            // 
            // lblReqType0
            // 
            this.lblReqType0.Location = new System.Drawing.Point(116, 129);
            this.lblReqType0.Name = "lblReqType0";
            this.lblReqType0.Size = new System.Drawing.Size(109, 20);
            this.lblReqType0.TabIndex = 5;
            this.lblReqType0.Text = "lblReqType0";
            this.lblReqType0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqValue0
            // 
            this.lblReqValue0.Location = new System.Drawing.Point(292, 129);
            this.lblReqValue0.Name = "lblReqValue0";
            this.lblReqValue0.Size = new System.Drawing.Size(106, 20);
            this.lblReqValue0.TabIndex = 4;
            this.lblReqValue0.Text = "lblReqValue0";
            this.lblReqValue0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Id";
            // 
            // btnRmvCriteria
            // 
            this.btnRmvCriteria.Location = new System.Drawing.Point(6, 174);
            this.btnRmvCriteria.Name = "btnRmvCriteria";
            this.btnRmvCriteria.Size = new System.Drawing.Size(104, 22);
            this.btnRmvCriteria.TabIndex = 2;
            this.btnRmvCriteria.Text = "Remove criteria";
            this.btnRmvCriteria.UseVisualStyleBackColor = true;
            this.btnRmvCriteria.Click += new System.EventHandler(this.btnRmvCriteria_Click);
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.Location = new System.Drawing.Point(6, 146);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(104, 22);
            this.btnAddCriteria.TabIndex = 1;
            this.btnAddCriteria.Text = "Add criteria";
            this.btnAddCriteria.UseVisualStyleBackColor = true;
            this.btnAddCriteria.Click += new System.EventHandler(this.btnAddCriteria_Click);
            // 
            // listCriterias
            // 
            this.listCriterias.FormattingEnabled = true;
            this.listCriterias.Location = new System.Drawing.Point(6, 19);
            this.listCriterias.Name = "listCriterias";
            this.listCriterias.Size = new System.Drawing.Size(104, 121);
            this.listCriterias.TabIndex = 0;
            this.listCriterias.SelectedIndexChanged += new System.EventHandler(this.listCriterias_SelectedIndexChanged);
            // 
            // btnIcon
            // 
            this.btnIcon.Location = new System.Drawing.Point(452, 83);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(22, 22);
            this.btnIcon.TabIndex = 28;
            this.btnIcon.Text = "+";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // btnFlags
            // 
            this.btnFlags.Location = new System.Drawing.Point(306, 83);
            this.btnFlags.Name = "btnFlags";
            this.btnFlags.Size = new System.Drawing.Size(22, 22);
            this.btnFlags.TabIndex = 27;
            this.btnFlags.Text = "+";
            this.btnFlags.UseVisualStyleBackColor = true;
            this.btnFlags.Click += new System.EventHandler(this.btnFlags_Click);
            // 
            // txtParentAchievement
            // 
            this.txtParentAchievement.Location = new System.Drawing.Point(311, 33);
            this.txtParentAchievement.Name = "txtParentAchievement";
            this.txtParentAchievement.Size = new System.Drawing.Size(163, 20);
            this.txtParentAchievement.TabIndex = 26;
            this.txtParentAchievement.TextChanged += new System.EventHandler(this.txtParentAchievement_TextChanged);
            // 
            // txtReward
            // 
            this.txtReward.Location = new System.Drawing.Point(253, 111);
            this.txtReward.Name = "txtReward";
            this.txtReward.Size = new System.Drawing.Size(221, 20);
            this.txtReward.TabIndex = 25;
            this.txtReward.TextChanged += new System.EventHandler(this.txtReward_TextChanged);
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(253, 58);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(47, 20);
            this.txtPoints.TabIndex = 24;
            this.txtPoints.TextChanged += new System.EventHandler(this.txtPoints_TextChanged);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(400, 59);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(74, 20);
            this.txtOrder.TabIndex = 23;
            this.txtOrder.TextChanged += new System.EventHandler(this.txtOrder_TextChanged);
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(253, 84);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(47, 20);
            this.txtFlags.TabIndex = 22;
            this.txtFlags.TextChanged += new System.EventHandler(this.txtFlags_TextChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(253, 137);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(55, 20);
            this.txtCategory.TabIndex = 21;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(368, 84);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(78, 20);
            this.txtIcon.TabIndex = 20;
            this.txtIcon.TextChanged += new System.EventHandler(this.txtIcon_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 105);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // listMap
            // 
            this.listMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMap.FormattingEnabled = true;
            this.listMap.Location = new System.Drawing.Point(284, 6);
            this.listMap.Name = "listMap";
            this.listMap.Size = new System.Drawing.Size(190, 21);
            this.listMap.TabIndex = 17;
            this.listMap.SelectedIndexChanged += new System.EventHandler(this.listMap_SelectedIndexChanged);
            // 
            // listFaction
            // 
            this.listFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listFaction.FormattingEnabled = true;
            this.listFaction.Items.AddRange(new object[] {
            "All",
            "Horde",
            "Alliance"});
            this.listFaction.Location = new System.Drawing.Point(125, 5);
            this.listFaction.Name = "listFaction";
            this.listFaction.Size = new System.Drawing.Size(72, 21);
            this.listFaction.TabIndex = 16;
            this.listFaction.SelectedIndexChanged += new System.EventHandler(this.listFaction_SelectedIndexChanged);
            // 
            // txtMap
            // 
            this.txtMap.Location = new System.Drawing.Point(237, 6);
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(41, 20);
            this.txtMap.TabIndex = 15;
            this.txtMap.TextChanged += new System.EventHandler(this.txtMap_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Points";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Faction";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Parent achievement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Order in category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Flags";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Icon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reward";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Map";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.groupBox1);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(480, 493);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "Category";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblCatParentId);
            this.groupBox1.Controls.Add(this.txtCatOrder);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtCatName);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtCatParentId);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtCatId);
            this.groupBox1.Location = new System.Drawing.Point(82, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(115, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "↩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReconstructTree_Click);
            // 
            // lblCatParentId
            // 
            this.lblCatParentId.Location = new System.Drawing.Point(143, 45);
            this.lblCatParentId.Name = "lblCatParentId";
            this.lblCatParentId.Size = new System.Drawing.Size(166, 20);
            this.lblCatParentId.TabIndex = 8;
            this.lblCatParentId.Text = "lblCatParentId";
            this.lblCatParentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCatOrder
            // 
            this.txtCatOrder.Location = new System.Drawing.Point(59, 97);
            this.txtCatOrder.Name = "txtCatOrder";
            this.txtCatOrder.Size = new System.Drawing.Size(50, 20);
            this.txtCatOrder.TabIndex = 7;
            this.txtCatOrder.TextChanged += new System.EventHandler(this.txtCatOrder_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(33, 13);
            this.label27.TabIndex = 6;
            this.label27.Text = "Order";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(59, 71);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(250, 20);
            this.txtCatName.TabIndex = 5;
            this.txtCatName.TextChanged += new System.EventHandler(this.txtCatName_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "Name";
            // 
            // txtCatParentId
            // 
            this.txtCatParentId.Location = new System.Drawing.Point(59, 45);
            this.txtCatParentId.Name = "txtCatParentId";
            this.txtCatParentId.Size = new System.Drawing.Size(50, 20);
            this.txtCatParentId.TabIndex = 3;
            this.txtCatParentId.TextChanged += new System.EventHandler(this.txtCatParentId_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(37, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(16, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Id";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "ParentId";
            // 
            // txtCatId
            // 
            this.txtCatId.Enabled = false;
            this.txtCatId.Location = new System.Drawing.Point(59, 19);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.Size = new System.Drawing.Size(50, 20);
            this.txtCatId.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 500);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 22);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 22);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save files";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 543);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tabAchievement);
            this.Controls.Add(this.btnAchAdd);
            this.Controls.Add(this.btnCatAdd);
            this.Controls.Add(this.lblTimeRender);
            this.Controls.Add(this.treeAchievements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Achievements Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabAchievement.ResumeLayout(false);
            this.tabPageAchievement.ResumeLayout(false);
            this.tabPageAchievement.PerformLayout();
            this.groupBoxCriterias.ResumeLayout(false);
            this.groupBoxCriterias.PerformLayout();
            this.tabPageCategory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeAchievements;
        private System.Windows.Forms.Label lblTimeRender;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCatAdd;
        private System.Windows.Forms.Button btnAchAdd;
        private System.Windows.Forms.TabControl tabAchievement;
        private System.Windows.Forms.TabPage tabPageAchievement;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox listMap;
        private System.Windows.Forms.ComboBox listFaction;
        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.TextBox txtParentAchievement;
        private System.Windows.Forms.TextBox txtReward;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Button btnFlags;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.GroupBox groupBoxCriterias;
        private System.Windows.Forms.Button btnRmvCriteria;
        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.ListBox listCriterias;
        private System.Windows.Forms.TextBox txtCriteriaOrder;
        private System.Windows.Forms.TextBox txtCriteriaName;
        private System.Windows.Forms.TextBox txtCriteriaAchievement;
        private System.Windows.Forms.TextBox txtReqType0;
        private System.Windows.Forms.TextBox txtCriteriaId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblReqType0;
        private System.Windows.Forms.Label lblReqValue0;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox listCriteriaType;
        private System.Windows.Forms.TextBox txtReqValue0;
        private System.Windows.Forms.Label lblReqType1;
        private System.Windows.Forms.Label lblReqType2;
        private System.Windows.Forms.Label lblReqValue2;
        private System.Windows.Forms.Label lblReqValue1;
        private System.Windows.Forms.TextBox txtReqValue1;
        private System.Windows.Forms.TextBox txtReqValue2;
        private System.Windows.Forms.TextBox txtReqType1;
        private System.Windows.Forms.TextBox txtReqType2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCriteriaFlags;
        private System.Windows.Forms.TextBox txtTimeLimit;
        private System.Windows.Forms.TextBox txtTimedType;
        private System.Windows.Forms.TextBox txtTimerStartEvent;
        private System.Windows.Forms.Label label14;
        private AchievementPanel panelRenderAchievement;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtAchievementRef;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnReconstructTree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCatParentId;
        private System.Windows.Forms.TextBox txtCatOrder;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCatParentId;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.Button button1;
    }
}