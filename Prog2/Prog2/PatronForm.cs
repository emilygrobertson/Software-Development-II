//Grading ID: L5135
//Program 2
//Due Date: 3/10/2019
//CIS 200-01
//This form allows users to add patrons to the Program.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class PatronForm : Form
    {
        // Precondition:  None
        // Postcondition: The PatronForm GUI is initialized
        public PatronForm()
        {
            InitializeComponent();
        }
        internal string PatronName // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in nameTextbox is returned
            get { return nameTextbox.Text; }
            // Precondition:  None
            // Postcondition: Text in nameTextbox is set to specified value
            set { nameTextbox.Text = value; }

        }
        // Precondition:  Attempting to change focus from nameTextbox
        // Postcondition: If entered value is valid string, focus will change,
        //                else focus will remain and error provider message set
        private void nameTextbox_Validating(object sender, CancelEventArgs e)
        {
            string text = nameTextbox.Text; // entered into nameTextbox
            //Will ask if sting is empty 
            //If it is blank, an error will not let it proceed to the next event
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(nameTextbox, "Enter a Patron Name"); // Set error message

                nameTextbox.SelectAll(); // Select all text in nameTextbox to ease correction
            }

        }

        // Precondition:  nameTextbox_Validating succeeded
        // Postcondition: Any error message set for nameTextbox is cleared
        //                Focus is allowed to change
        private void nameTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTextbox, ""); // Clears error message
        }

        internal string PatronID // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in IDTextbox is returned
            get { return IDTextbox.Text; }
            // Precondition:  None
            // Postcondition: Text in IDTextbox is set to specified value
            set { IDTextbox.Text = value; }
        }
        // Precondition:  Attempting to change focus from IDTextbox
        // Postcondition: If entered value is valid string, focus will change,
        //                else focus will remain and error provider message set
        private void IDTextbox_Validating(object sender, CancelEventArgs e)
        {
            string text = IDTextbox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(IDTextbox, "Enter a Patron ID"); // Set error message

                nameTextbox.SelectAll(); // Select all text in IDTextbox to ease correction
            }

        }
        // Precondition:  IDTextbox_Validating succeeded
        // Postcondition: Any error message set for IDTextbox is cleared
        //                Focus is allowed to change
        private void IDTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(IDTextbox, ""); // Clears error message
        }
        // Precondition:  User has initiated click on OkBtn
        // Postcondition: If all controls on form validate, textboxes are dismissed with OK result
        private void patronOKButton_Click(object sender, EventArgs e)
        {
            {
                if (this.ValidateChildren())
                    this.DialogResult = DialogResult.OK;
            }
        }
        // Precondition:  User has initiated click on cancelBtn
        // Postcondition: If left-click, textboxes are dismissed with Cancel result
        private void patronCancelButton_MouseDown(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left) // Was it a left-click?
                    this.DialogResult = DialogResult.Cancel;
        }
    }
}
