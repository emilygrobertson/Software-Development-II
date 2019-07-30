namespace LibraryItems
{
    partial class Return
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
            this.returnBookLbl = new System.Windows.Forms.Label();
            this.returnBookCombo = new System.Windows.Forms.ComboBox();
            this.returnButtone = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnBookLbl
            // 
            this.returnBookLbl.AutoSize = true;
            this.returnBookLbl.Location = new System.Drawing.Point(126, 49);
            this.returnBookLbl.Name = "returnBookLbl";
            this.returnBookLbl.Size = new System.Drawing.Size(63, 13);
            this.returnBookLbl.TabIndex = 0;
            this.returnBookLbl.Text = "Select Item:";
            // 
            // returnBookCombo
            // 
            this.returnBookCombo.FormattingEnabled = true;
            this.returnBookCombo.Location = new System.Drawing.Point(103, 89);
            this.returnBookCombo.Name = "returnBookCombo";
            this.returnBookCombo.Size = new System.Drawing.Size(121, 21);
            this.returnBookCombo.TabIndex = 1;
            this.returnBookCombo.Validating += new System.ComponentModel.CancelEventHandler(this.returnBookCombo_Validating);
            this.returnBookCombo.Validated += new System.EventHandler(this.returnBookCombo_Validated);
            // 
            // returnButtone
            // 
            this.returnButtone.Location = new System.Drawing.Point(129, 128);
            this.returnButtone.Name = "returnButtone";
            this.returnButtone.Size = new System.Drawing.Size(75, 23);
            this.returnButtone.TabIndex = 4;
            this.returnButtone.Text = "OK";
            this.returnButtone.UseVisualStyleBackColor = true;
            this.returnButtone.Click += new System.EventHandler(this.returnButtone_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(129, 170);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 227);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.returnButtone);
            this.Controls.Add(this.returnBookCombo);
            this.Controls.Add(this.returnBookLbl);
            this.Name = "Return";
            this.Text = "Return";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label returnBookLbl;
        private System.Windows.Forms.ComboBox returnBookCombo;
        private System.Windows.Forms.Button returnButtone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button cancelButton;
    }
}