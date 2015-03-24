namespace World_Editor.Editors.GameTipsEditor
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
            this.listGameTips = new System.Windows.Forms.ListBox();
            this.btnAddTip = new System.Windows.Forms.Button();
            this.btnDelTip = new System.Windows.Forms.Button();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tipsColorDialog = new System.Windows.Forms.ColorDialog();
            this.btnTipsColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listGameTips
            // 
            this.listGameTips.FormattingEnabled = true;
            this.listGameTips.Location = new System.Drawing.Point(12, 12);
            this.listGameTips.Name = "listGameTips";
            this.listGameTips.Size = new System.Drawing.Size(318, 95);
            this.listGameTips.TabIndex = 0;
            this.listGameTips.SelectedIndexChanged += new System.EventHandler(this.listGameTips_SelectedIndexChanged);
            // 
            // btnAddTip
            // 
            this.btnAddTip.Location = new System.Drawing.Point(336, 12);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(71, 28);
            this.btnAddTip.TabIndex = 1;
            this.btnAddTip.Text = "Add new tip";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // btnDelTip
            // 
            this.btnDelTip.Location = new System.Drawing.Point(336, 45);
            this.btnDelTip.Name = "btnDelTip";
            this.btnDelTip.Size = new System.Drawing.Size(71, 28);
            this.btnDelTip.TabIndex = 2;
            this.btnDelTip.Text = "Delete tip";
            this.btnDelTip.UseVisualStyleBackColor = true;
            this.btnDelTip.Click += new System.EventHandler(this.btnDelTip_Click);
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(12, 142);
            this.txtTip.Multiline = true;
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(395, 85);
            this.txtTip.TabIndex = 3;
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preview";
            // 
            // lblPreview
            // 
            this.lblPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPreview.Location = new System.Drawing.Point(12, 251);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.ReadOnly = true;
            this.lblPreview.Size = new System.Drawing.Size(395, 60);
            this.lblPreview.TabIndex = 7;
            this.lblPreview.Text = "lblPreview";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(336, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save DBC";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTipsColor
            // 
            this.btnTipsColor.Location = new System.Drawing.Point(336, 113);
            this.btnTipsColor.Name = "btnTipsColor";
            this.btnTipsColor.Size = new System.Drawing.Size(71, 23);
            this.btnTipsColor.TabIndex = 9;
            this.btnTipsColor.Text = "Couleur";
            this.btnTipsColor.UseVisualStyleBackColor = true;
            this.btnTipsColor.Click += new System.EventHandler(this.btnTipsColor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 323);
            this.Controls.Add(this.btnTipsColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.btnDelTip);
            this.Controls.Add(this.btnAddTip);
            this.Controls.Add(this.listGameTips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameTips Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listGameTips;
        private System.Windows.Forms.Button btnAddTip;
        private System.Windows.Forms.Button btnDelTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox lblPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColorDialog tipsColorDialog;
        private System.Windows.Forms.Button btnTipsColor;
    }
}