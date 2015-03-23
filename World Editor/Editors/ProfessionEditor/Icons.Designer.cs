namespace World_Editor.Editors.ProfessionEditor
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
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelIcons
            // 
            this.panelIcons.Location = new System.Drawing.Point(13, 13);
            this.panelIcons.Name = "panelIcons";
            this.panelIcons.Size = new System.Drawing.Size(259, 237);
            this.panelIcons.TabIndex = 0;
            this.panelIcons.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIcons_Paint);
            this.panelIcons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIcons_MouseDown);
            this.panelIcons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelIcons_MouseMove);
            this.panelIcons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelIcons_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id :";
            // 
            // txtIconId
            // 
            this.txtIconId.Location = new System.Drawing.Point(41, 269);
            this.txtIconId.Name = "txtIconId";
            this.txtIconId.Size = new System.Drawing.Size(38, 20);
            this.txtIconId.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(236, 267);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(36, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Icons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtIconId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIcons);
            this.Name = "Icons";
            this.Text = "Icons";
            this.Load += new System.EventHandler(this.Icons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIcons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIconId;
        private System.Windows.Forms.Button btnOk;
    }
}