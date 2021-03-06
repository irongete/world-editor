namespace World_Editor.Dialogs
{
    partial class SpellDialog
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
            this.lstSpells = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchSpells = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidateComponent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSpells
            // 
            this.lstSpells.FormattingEnabled = true;
            this.lstSpells.Location = new System.Drawing.Point(12, 32);
            this.lstSpells.Name = "lstSpells";
            this.lstSpells.Size = new System.Drawing.Size(250, 212);
            this.lstSpells.TabIndex = 0;
            this.lstSpells.SelectedIndexChanged += new System.EventHandler(this.lstSpells_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Recherche :";
            // 
            // txtSearchSpells
            // 
            this.txtSearchSpells.Location = new System.Drawing.Point(84, 6);
            this.txtSearchSpells.Name = "txtSearchSpells";
            this.txtSearchSpells.Size = new System.Drawing.Size(178, 20);
            this.txtSearchSpells.TabIndex = 6;
            this.txtSearchSpells.TextChanged += new System.EventHandler(this.txtSearchSpells_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidateComponent
            // 
            this.btnValidateComponent.Location = new System.Drawing.Point(15, 250);
            this.btnValidateComponent.Name = "btnValidateComponent";
            this.btnValidateComponent.Size = new System.Drawing.Size(75, 32);
            this.btnValidateComponent.TabIndex = 10;
            this.btnValidateComponent.Text = "Valider";
            this.btnValidateComponent.UseVisualStyleBackColor = true;
            this.btnValidateComponent.Click += new System.EventHandler(this.btnValidateComponent_Click);
            // 
            // SpellDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 283);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidateComponent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchSpells);
            this.Controls.Add(this.lstSpells);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpellDialog";
            this.Text = "SpellDialog";
            this.Load += new System.EventHandler(this.SpellDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSpells;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchSpells;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidateComponent;
    }
}