namespace LibraryItems
{
    partial class PatronForm
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
            this.patronNameLbl = new System.Windows.Forms.Label();
            this.IDLbl = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.patronOKButton = new System.Windows.Forms.Button();
            this.patronCancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // patronNameLbl
            // 
            this.patronNameLbl.AutoSize = true;
            this.patronNameLbl.Location = new System.Drawing.Point(12, 55);
            this.patronNameLbl.Name = "patronNameLbl";
            this.patronNameLbl.Size = new System.Drawing.Size(72, 13);
            this.patronNameLbl.TabIndex = 0;
            this.patronNameLbl.Text = " Patron Name";
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(12, 91);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(55, 13);
            this.IDLbl.TabIndex = 1;
            this.IDLbl.Text = " Patron ID";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(103, 55);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 2;
            this.nameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextbox_Validating);
            this.nameTextbox.Validated += new System.EventHandler(this.nameTextbox_Validated);
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(103, 81);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(100, 20);
            this.IDTextbox.TabIndex = 3;
            this.IDTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.IDTextbox_Validating);
            this.IDTextbox.Validated += new System.EventHandler(this.IDTextbox_Validated);
            // 
            // patronOKButton
            // 
            this.patronOKButton.Location = new System.Drawing.Point(9, 144);
            this.patronOKButton.Name = "patronOKButton";
            this.patronOKButton.Size = new System.Drawing.Size(75, 23);
            this.patronOKButton.TabIndex = 4;
            this.patronOKButton.Text = "OK";
            this.patronOKButton.UseVisualStyleBackColor = true;
            this.patronOKButton.Click += new System.EventHandler(this.patronOKButton_Click);
            // 
            // patronCancelButton
            // 
            this.patronCancelButton.Location = new System.Drawing.Point(125, 144);
            this.patronCancelButton.Name = "patronCancelButton";
            this.patronCancelButton.Size = new System.Drawing.Size(75, 23);
            this.patronCancelButton.TabIndex = 5;
            this.patronCancelButton.Text = "Cancel";
            this.patronCancelButton.UseVisualStyleBackColor = true;
            this.patronCancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.patronCancelButton_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 195);
            this.Controls.Add(this.patronCancelButton);
            this.Controls.Add(this.patronOKButton);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.patronNameLbl);
            this.Name = "PatronForm";
            this.Text = "New Patron";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patronNameLbl;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Button patronOKButton;
        private System.Windows.Forms.Button patronCancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}