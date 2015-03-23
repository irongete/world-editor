namespace World_Editor.Editors.POIsEditor
{
    partial class Icons
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
            this.panelIcons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIconId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelIcons
            // 
            this.panelIcons.BackColor = System.Drawing.SystemColors.Control;
            this.panelIcons.Location = new System.Drawing.Point(12, 12);
            this.panelIcons.Name = "panelIcons";
            this.panelIcons.Size = new System.Drawing.Size(256, 256);
            this.panelIcons.TabIndex = 0;
            this.panelIcons.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIcons_Paint);
            this.panelIcons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIcons_MouseDown);
            this.panelIcons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelIcons_MouseMove);
            this.panelIcons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelIcons_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // txtIconId
            // 
            this.txtIconId.Location = new System.Drawing.Point(44, 274);
            this.txtIconId.Name = "txtIconId";
            this.txtIconId.Size = new System.Drawing.Size(46, 20);
            this.txtIconId.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Icons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 300);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtIconId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIcons);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Icons";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Icons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Icons_FormClosing);
            this.Load += new System.EventHandler(this.Icons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIcons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIconId;
        private System.Windows.Forms.Button btnClose;
    }
}