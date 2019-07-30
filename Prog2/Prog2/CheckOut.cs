//Grading ID: L5135
//Program 2
//Due Date: 3/10/2019
//CIS 200-01
//This form allows users to check out books from the library list.
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
    public partial class CheckOut : Form
    {
        //This creates a new list of items that are not checked out.
        private List<LibraryItem> notCheckedOut= new List<LibraryItem>();
        internal string CallNumber // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition:This will return the index of items not checked out
            get { return notCheckedOut[ItemIndex].CallNumber; }
        }
        internal int ItemIndex //can be accessed by other classes in the same namespace
        {
            // Precondition:  None
            // Postcondition: This will return the  book items from the ComboBox that were selected.
            get { return bookComboBox.SelectedIndex; }
        }

        internal int PatronIndex// can be accessed by other classes in the same namespace
        {
            // Precondition:  None
            // Postcondition: This will return the patrons from the ComboBox that were selected.
            get { return patronComboBox.SelectedIndex; }
        }
        public CheckOut(List<LibraryItem> items, List<LibraryPatron> patrons)
        {    //Precondition: none
            //Postcondition: The Checkout Form GUI is initialized
            InitializeComponent();
            foreach (LibraryItem item in items) //This uses a foreach loop to checkout items if they are aren't already.
            {
                if (!item.IsCheckedOut())
                {
                    bookComboBox.Items.Add($"{item.Title},{item.CallNumber}");
                    notCheckedOut.Add(item);
                }
            }
            foreach (LibraryPatron patron in patrons)
            {
                patronComboBox.Items.Add($"{patron.PatronName},{patron.PatronID}"); 
            }


        }
        // Precondition:  User has initiated click on OkBtn
        // Postcondition: If all controls on form validate, textboxes are dismissed with OK result
        private void OKButton_Click(object sender, EventArgs e)
        {
            if(bookComboBox.SelectedIndex > -1 && patronComboBox.SelectedIndex >-1  && this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }

        }
        //Precondition: Attempting to change focus from bookComboBox
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message set
        private void bookComboBox_Validating(object sender, CancelEventArgs e)
        {
            if(((ComboBox)sender).SelectedIndex == -1)
            {
                e.Cancel = true; // Stops focus changing process
                errorProvider1.SetError((ComboBox)sender, "Select a Value!"); // Set error message
            }
        }
        // Precondition:  bookComboBox_Validating succeeded
        // Postcondition: Any error message set for BookComboBox is cleared
        //                Focus is allowed to change
        private void bookComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((ComboBox)sender, ""); // Clears error message
        }

        // Precondition:  User has initiated click on cancel Button
        // Postcondition: If left-click, textboxes are dismissed with Cancel result
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
