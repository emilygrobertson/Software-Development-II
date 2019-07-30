namespace LibraryItems
{
    partial class Program2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedOutItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronToolStripMenuItem,
            this.bookToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "&Insert";
            // 
            // patronToolStripMenuItem
            // 
            this.patronToolStripMenuItem.Name = "patronToolStripMenuItem";
            this.patronToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.patronToolStripMenuItem.Text = "&Patron";
            this.patronToolStripMenuItem.Click += new System.EventHandler(this.patronToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.bookToolStripMenuItem.Text = "&Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOutToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.itemToolStripMenuItem.Text = "&Item";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.checkOutToolStripMenuItem.Text = "&CheckOut";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.returnToolStripMenuItem.Text = "&Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronListToolStripMenuItem,
            this.itemListToolStripMenuItem,
            this.checkedOutItemsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // patronListToolStripMenuItem
            // 
            this.patronListToolStripMenuItem.Name = "patronListToolStripMenuItem";
            this.patronListToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.patronListToolStripMenuItem.Text = "&Patron List";
            this.patronListToolStripMenuItem.Click += new System.EventHandler(this.patronListToolStripMenuItem_Click);
            // 
            // itemListToolStripMenuItem
            // 
            this.itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
            this.itemListToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.itemListToolStripMenuItem.Text = "&Item List";
            this.itemListToolStripMenuItem.Click += new System.EventHandler(this.itemListToolStripMenuItem_Click);
            // 
            // checkedOutItemsToolStripMenuItem
            // 
            this.checkedOutItemsToolStripMenuItem.Name = "checkedOutItemsToolStripMenuItem";
            this.checkedOutItemsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.checkedOutItemsToolStripMenuItem.Text = "&Checked Out Items";
            this.checkedOutItemsToolStripMenuItem.Click += new System.EventHandler(this.checkedOutItemsToolStripMenuItem_Click);
            // 
            // mainTextbox
            // 
            this.mainTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextbox.Location = new System.Drawing.Point(0, 24);
            this.mainTextbox.Multiline = true;
            this.mainTextbox.Name = "mainTextbox";
            this.mainTextbox.ReadOnly = true;
            this.mainTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTextbox.Size = new System.Drawing.Size(525, 306);
            this.mainTextbox.TabIndex = 3;
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 330);
            this.Controls.Add(this.mainTextbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Program2";
            this.Text = "Program 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedOutItemsToolStripMenuItem;
        private System.Windows.Forms.TextBox mainTextbox;
    }
}

