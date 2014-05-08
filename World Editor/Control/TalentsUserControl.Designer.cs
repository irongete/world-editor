namespace World_Editor.Control
{
    partial class TalentsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.talentTabScroll = new System.Windows.Forms.VScrollBar();
            this.panelOut = new System.Windows.Forms.Panel();
            this.panelIn = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // talentTabScroll
            // 
            this.talentTabScroll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.talentTabScroll.Location = new System.Drawing.Point(300, 0);
            this.talentTabScroll.Name = "talentTabScroll";
            this.talentTabScroll.Size = new System.Drawing.Size(17, 330);
            this.talentTabScroll.SmallChange = 5;
            this.talentTabScroll.TabIndex = 21;
            this.talentTabScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.talentTabScroll_Scroll);
            // 
            // panelOut
            // 
            this.panelOut.Location = new System.Drawing.Point(0, 0);
            this.panelOut.Name = "panelOut";
            this.panelOut.Size = new System.Drawing.Size(300, 330);
            this.panelOut.TabIndex = 22;
            // 
            // panelIn
            // 
            this.panelIn.Location = new System.Drawing.Point(0, 0);
            this.panelIn.Name = "panelIn";
            this.panelIn.Size = new System.Drawing.Size(300, 700);
            this.panelIn.TabIndex = 23;
            this.panelIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIn_Paint);
            this.panelIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIn_MouseDown);
            this.panelIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelIn_MouseUp);
            // 
            // TalentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelIn);
            this.Controls.Add(this.talentTabScroll);
            this.MaximumSize = new System.Drawing.Size(317, 330);
            this.MinimumSize = new System.Drawing.Size(317, 330);
            this.Name = "TalentsUserControl";
            this.Size = new System.Drawing.Size(317, 330);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar talentTabScroll;
        private System.Windows.Forms.Panel panelOut;
        private System.Windows.Forms.Panel panelIn;
    }
}
