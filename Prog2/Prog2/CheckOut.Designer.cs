namespace LibraryItems
{
    partial class CheckOut
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
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.bookCheckOutLbl = new System.Windows.Forms.Label();
            this.patronCheckoutLbl = new System.Windows.Forms.Label();
            this.patronComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookComboBox
            // 
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(29, 57);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(121, 21);
            this.bookComboBox.TabIndex = 0;
            this.bookComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookComboBox_Validating);
            this.bookComboBox.Validated += new System.EventHandler(this.bookComboBox_Validated);
            // 
            // bookCheckOutLbl
            // 
            this.bookCheckOutLbl.AutoSize = true;
            this.bookCheckOutLbl.Location = new System.Drawing.Point(50, 22);
            this.bookCheckOutLbl.Name = "bookCheckOutLbl";
            this.bookCheckOutLbl.Size = new System.Drawing.Size(63, 13);
            this.bookCheckOutLbl.TabIndex = 1;
            this.bookCheckOutLbl.Text = "Select Item:";
            // 
            // patronCheckoutLbl
            // 
            this.patronCheckoutLbl.AutoSize = true;
            this.patronCheckoutLbl.Location = new System.Drawing.Point(246, 22);
            this.patronCheckoutLbl.Name = "patronCheckoutLbl";
            this.patronCheckoutLbl.Size = new System.Drawing.Size(71, 13);
            this.patronCheckoutLbl.TabIndex = 2;
            this.patronCheckoutLbl.Text = "Select Patron";
            // 
            // patronComboBox
            // 
            this.patronComboBox.FormattingEnabled = true;
            this.patronComboBox.Location = new System.Drawing.Point(228, 57);
            this.patronComboBox.Name = "patronComboBox";
            this.patronComboBox.Size = new System.Drawing.Size(121, 21);
            this.patronComboBox.TabIndex = 3;
            this.patronComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookComboBox_Validating);
            this.patronComboBox.Validated += new System.EventHandler(this.bookComboBox_Validated);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(148, 105);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(148, 158);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 219);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.patronComboBox);
            this.Controls.Add(this.patronCheckoutLbl);
            this.Controls.Add(this.bookCheckOutLbl);
            this.Controls.Add(this.bookComboBox);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.Label bookCheckOutLbl;
        private System.Windows.Forms.Label patronCheckoutLbl;
        private System.Windows.Forms.ComboBox patronComboBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button cancelButton;
    }
}