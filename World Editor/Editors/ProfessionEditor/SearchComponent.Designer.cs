namespace World_Editor.Editors.ProfessionEditor
{
    partial class SearchComponent
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
            this.lstComponents = new System.Windows.Forms.ListBox();
            this.txtSearchComponents = new System.Windows.Forms.TextBox();
            this.txtComponentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidateComponent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstComponents
            // 
            this.lstComponents.FormattingEnabled = true;
            this.lstComponents.Location = new System.Drawing.Point(12, 38);
            this.lstComponents.Name = "lstComponents";
            this.lstComponents.Size = new System.Drawing.Size(224, 199);
            this.lstComponents.TabIndex = 0;
            this.lstComponents.SelectedIndexChanged += new System.EventHandler(this.lstComponents_SelectedIndexChanged);
            // 
            // txtSearchComponents
            // 
            this.txtSearchComponents.Location = new System.Drawing.Point(83, 12);
            this.txtSearchComponents.Name = "txtSearchComponents";
            this.txtSearchComponents.Size = new System.Drawing.Size(152, 20);
            this.txtSearchComponents.TabIndex = 1;
            this.txtSearchComponents.TextChanged += new System.EventHandler(this.txtSearchComponents_TextChanged);
            // 
            // txtComponentID
            // 
            this.txtComponentID.Location = new System.Drawing.Point(40, 243);
            this.txtComponentID.Name = "txtComponentID";
            this.txtComponentID.Size = new System.Drawing.Size(67, 20);
            this.txtComponentID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id :";
            // 
            // btnValidateComponent
            // 
            this.btnValidateComponent.Location = new System.Drawing.Point(160, 242);
            this.btnValidateComponent.Name = "btnValidateComponent";
            this.btnValidateComponent.Size = new System.Drawing.Size(75, 20);
            this.btnValidateComponent.TabIndex = 4;
            this.btnValidateComponent.Text = "Valider";
            this.btnValidateComponent.UseVisualStyleBackColor = true;
            this.btnValidateComponent.Click += new System.EventHandler(this.btnValidateComponent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recherche :";
            // 
            // SearchComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValidateComponent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComponentID);
            this.Controls.Add(this.txtSearchComponents);
            this.Controls.Add(this.lstComponents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchComponent";
            this.Text = "Recherche de composants";
            this.Load += new System.EventHandler(this.SearchComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstComponents;
        private System.Windows.Forms.TextBox txtSearchComponents;
        private System.Windows.Forms.TextBox txtComponentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidateComponent;
        private System.Windows.Forms.Label label2;
    }
}