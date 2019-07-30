//Grading ID: L5135
//Program 2
//Due Date: 3/10/2019
//CIS 200-01
//This form allows users to return books that were already checked out.
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
    public partial class Return : Form
    {
        //This creates a new list of items that are checked out.
        private List<LibraryItem> returnItems = new List<LibraryItem>();
        internal string CallNumber //Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition:This will return the index of items checked out
            get { return returnItems[ItemIndex].CallNumber; }
        }
        internal int ItemIndex //Can be accessed by other classes in same namespace.
        {
            // Precondition:  None
            // Postcondition: This will return the  book items from the ComboBox that were selected.
            get { return returnBookCombo.SelectedIndex; }
        }

        public Return(List<LibraryItem> items)
        {
            //Precondition: none
            //Postcondition: The Return Form GUI is initialized
            InitializeComponent();
            foreach (LibraryItem item in items) //This uses a foreach loop to return items that are already checked out.
            {
                if (item.IsCheckedOut())
                {
                    returnBookCombo.Items.Add($"{item.Title},{item.CallNumber}");
                    returnItems.Add(item);
                }
            }
        }

        // Precondition:  User has initiated click on OkBtn
        // Postcondition: If all controls on form validate, textboxes are dismissed with OK result
        private void returnButtone_Click(object sender, EventArgs e)
        {
            if (returnBookCombo.SelectedIndex > -1 && this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        //Precondition: Attempting to change focus from returnBookCombo
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message set
        private void returnBookCombo_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == -1)
            {
                e.Cancel = true; // Stops focus changing process
                errorProvider1.SetError((ComboBox)sender, "Select a Value!"); // Set error message
            }
        }

        // Precondition:  returnBookCombo_Validating succeeded
        // Postcondition: Any error message set for returnBookCombo is cleared
        //                Focus is allowed to change
        private void returnBookCombo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((ComboBox)sender, ""); // Clears error message
        }

        // Precondition:  User has initiated click on cancelButton
        // Postcondition: If left-click, textboxes are dismissed with Cancel result
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }

    
}


