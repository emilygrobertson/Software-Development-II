namespace LibraryItems
{
    partial class BookForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.publisherTextbox = new System.Windows.Forms.TextBox();
            this.copyrightYearTextbox = new System.Windows.Forms.TextBox();
            this.loanPeriodTextbox = new System.Windows.Forms.TextBox();
            this.callNumberTextbox = new System.Windows.Forms.TextBox();
            this.bookOKButton = new System.Windows.Forms.Button();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.copyrightYearLabel = new System.Windows.Forms.Label();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.loanPeriodLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorTextbox = new System.Windows.Forms.TextBox();
            this.bookCancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(69, 34);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(100, 20);
            this.titleTextbox.TabIndex = 1;
            this.titleTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.titleTextbox_Validating);
            this.titleTextbox.Validated += new System.EventHandler(this.titleTextbox_Validated);
            // 
            // publisherTextbox
            // 
            this.publisherTextbox.Location = new System.Drawing.Point(69, 57);
            this.publisherTextbox.Name = "publisherTextbox";
            this.publisherTextbox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextbox.TabIndex = 2;
            // 
            // copyrightYearTextbox
            // 
            this.copyrightYearTextbox.Location = new System.Drawing.Point(69, 82);
            this.copyrightYearTextbox.Name = "copyrightYearTextbox";
            this.copyrightYearTextbox.Size = new System.Drawing.Size(100, 20);
            this.copyrightYearTextbox.TabIndex = 3;
            this.copyrightYearTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.copyrightYearTextbox_Validating);
            this.copyrightYearTextbox.Validated += new System.EventHandler(this.copyrightYearTextbox_Validated);
            // 
            // loanPeriodTextbox
            // 
            this.loanPeriodTextbox.Location = new System.Drawing.Point(69, 108);
            this.loanPeriodTextbox.Name = "loanPeriodTextbox";
            this.loanPeriodTextbox.Size = new System.Drawing.Size(100, 20);
            this.loanPeriodTextbox.TabIndex = 4;
            this.loanPeriodTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.loanPeriodTextbox_Validating);
            this.loanPeriodTextbox.Validated += new System.EventHandler(this.loanPeriodTextbox_Validated);
            // 
            // callNumberTextbox
            // 
            this.callNumberTextbox.Location = new System.Drawing.Point(69, 134);
            this.callNumberTextbox.Name = "callNumberTextbox";
            this.callNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.callNumberTextbox.TabIndex = 5;
            this.callNumberTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.callNumberTextbox_Validating);
            this.callNumberTextbox.Validated += new System.EventHandler(this.callNumberTextbox_Validated);
            // 
            // bookOKButton
            // 
            this.bookOKButton.Location = new System.Drawing.Point(11, 207);
            this.bookOKButton.Name = "bookOKButton";
            this.bookOKButton.Size = new System.Drawing.Size(75, 23);
            this.bookOKButton.TabIndex = 6;
            this.bookOKButton.Text = "Ok";
            this.bookOKButton.UseVisualStyleBackColor = true;
            this.bookOKButton.Click += new System.EventHandler(this.bookOKButton_Click);
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(-1, 60);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(50, 13);
            this.publisherLabel.TabIndex = 7;
            this.publisherLabel.Text = "Publisher";
            // 
            // copyrightYearLabel
            // 
            this.copyrightYearLabel.AutoSize = true;
            this.copyrightYearLabel.Location = new System.Drawing.Point(-1, 89);
            this.copyrightYearLabel.Name = "copyrightYearLabel";
            this.copyrightYearLabel.Size = new System.Drawing.Size(73, 13);
            this.copyrightYearLabel.TabIndex = 8;
            this.copyrightYearLabel.Text = "CopyrightYear";
            // 
            // callNumberLabel
            // 
            this.callNumberLabel.AutoSize = true;
            this.callNumberLabel.Location = new System.Drawing.Point(-1, 137);
            this.callNumberLabel.Name = "callNumberLabel";
            this.callNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.callNumberLabel.TabIndex = 9;
            this.callNumberLabel.Text = " Call Number";
            // 
            // loanPeriodLabel
            // 
            this.loanPeriodLabel.AutoSize = true;
            this.loanPeriodLabel.Location = new System.Drawing.Point(-1, 112);
            this.loanPeriodLabel.Name = "loanPeriodLabel";
            this.loanPeriodLabel.Size = new System.Drawing.Size(67, 13);
            this.loanPeriodLabel.TabIndex = 10;
            this.loanPeriodLabel.Text = " Loan Period";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(8, 160);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 11;
            this.authorLabel.Text = " Author";
            // 
            // authorTextbox
            // 
            this.authorTextbox.Location = new System.Drawing.Point(69, 160);
            this.authorTextbox.Name = "authorTextbox";
            this.authorTextbox.Size = new System.Drawing.Size(100, 20);
            this.authorTextbox.TabIndex = 12;
            // 
            // bookCancelButton
            // 
            this.bookCancelButton.Location = new System.Drawing.Point(114, 207);
            this.bookCancelButton.Name = "bookCancelButton";
            this.bookCancelButton.Size = new System.Drawing.Size(75, 23);
            this.bookCancelButton.TabIndex = 13;
            this.bookCancelButton.Text = "Cancel";
            this.bookCancelButton.UseVisualStyleBackColor = true;
            this.bookCancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bookCancelButton_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 281);
            this.Controls.Add(this.bookCancelButton);
            this.Controls.Add(this.authorTextbox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.loanPeriodLabel);
            this.Controls.Add(this.callNumberLabel);
            this.Controls.Add(this.copyrightYearLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.bookOKButton);
            this.Controls.Add(this.callNumberTextbox);
            this.Controls.Add(this.loanPeriodTextbox);
            this.Controls.Add(this.copyrightYearTextbox);
            this.Controls.Add(this.publisherTextbox);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.titleLabel);
            this.Name = "BookForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.TextBox publisherTextbox;
        private System.Windows.Forms.TextBox copyrightYearTextbox;
        private System.Windows.Forms.TextBox loanPeriodTextbox;
        private System.Windows.Forms.TextBox callNumberTextbox;
        private System.Windows.Forms.Button bookOKButton;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label copyrightYearLabel;
        private System.Windows.Forms.Label callNumberLabel;
        private System.Windows.Forms.Label loanPeriodLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorTextbox;
        private System.Windows.Forms.Button bookCancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}