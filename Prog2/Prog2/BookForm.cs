//Grading ID: L5135
//Program 2
//Due Date: 3/10/2019
//CIS 200-01
//This form allows users to add books to the Program.
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
    public partial class BookForm : Form
    {
        const int DEFAULT_PERIOD = 0;// default loan period

        // Precondition:  None
        // Postcondition: The BookForm GUI is initialized
        public BookForm()
        {
            InitializeComponent();
        }
        internal string BookTitle // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in titleTextbox is returned
            get { return titleTextbox.Text; }
            // Precondition:  None
            // Postcondition: Text in titleTextbox is set to specified value
            set { titleTextbox.Text = value; }
        }

        // Precondition:  Attempting to change focus from titleTextbox
        // Postcondition: If entered value is valid string, focus will change,
        //                else focus will remain and error provider message set
        private void titleTextbox_Validating(object sender, CancelEventArgs e)
        {
            string text = titleTextbox.Text;  // entered into nameTextbox
            //Will ask if sting is empty 
            //If it is blank, an error will not let it proceed to the next event
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(titleTextbox, "Enter a Title"); // Set error message

                titleTextbox.SelectAll(); // Select all text in titleTextbox to ease correction
            }
        }
        // Precondition:  titleTextbox_Validating succeeded
        // Postcondition: Any error message set for titleTextbox is cleared
        //                Focus is allowed to change
        private void titleTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(titleTextbox, ""); // Clears error message
        }

       internal string BookPublisher// Can be accessed by other classes in same namespace

        { // Precondition:  None
            // Postcondition: Text in publisherTextbox is returned
            get { return publisherTextbox.Text; }
            // Precondition:  None
            // Postcondition: Text in publisherTextbox is set to specified value
            set { publisherTextbox.Text = value; }
        }

      internal string BookCopyrightYear// Can be accessed by other classes in same namespace

        {
            // Precondition:  None
            // Postcondition: Text in copyrightYearTextbox is returned
            get { return copyrightYearTextbox.Text; }
            // Precondition:  None
            // Postcondition: Text in copyrightYearTextbox is set to specified value
            set { copyrightYearTextbox.Text = value; }
        }
        private void copyrightYearTextbox_Validating(object sender, CancelEventArgs e)
        {
            int number;// Value entered into copyrightYearTextbox

           // Will try to parse text as int
          // If fails, TryParse returns false
          // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(copyrightYearTextbox.Text, out number))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(copyrightYearTextbox, "Enter an integer!"); // Set error message

                copyrightYearTextbox.SelectAll(); // Select all text in copyrightYearTextbox to ease correction
            }
            else
            {
                if (number < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    errorProvider1.SetError(copyrightYearTextbox, "Enter a non-negative integer!"); // Set error message

                    copyrightYearTextbox.SelectAll(); // Select all text in copyrightYearTextbox to ease correction
                }
            }
        }
        // Precondition:  copyrightYearTextbox_Validating succeeded
        // Postcondition: Any error message set for copyrightYearTextbox is cleared
        //                Focus is allowed to change
        private void copyrightYearTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(copyrightYearTextbox, ""); // Clears error message
        }

        internal string BookLoanPeriod// Can be accessed by other classes in same namespace
        
        {
            // Precondition:  None
            // Postcondition: Text in loanPeriodTextbox is returned
            get { return loanPeriodTextbox.Text; }
            // Precondition:  None
            // Postcondition: Text in loanPeriodTextbox is set to specified value
            set { loanPeriodTextbox.Text = value; }
        }
        private void loanPeriodTextbox_Validating(object sender, CancelEventArgs e)
        {
            int number; // Value entered into loanPeriodTextbox
            // Will try to parse text as int
           // If fails, TryParse returns false
          // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(loanPeriodTextbox.Text, out number))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(loanPeriodTextbox, "Enter an integer!"); // Set error message

               loanPeriodTextbox.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (number < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    errorProvider1.SetError(loanPeriodTextbox, "Enter a non-negative integer!"); // Set error message

                    loanPeriodTextbox.SelectAll(); // Select all text in inputTx to ease correction
                }
            }
        }
        // Precondition:  loanPeriodTextbox_Validating succeeded
        // Postcondition: Any error message set for loanPeriodTextbox is cleared
        //                Focus is allowed to change
        private void loanPeriodTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(loanPeriodTextbox, ""); // Clears error message
        }
        internal string BookCallNumber // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in callNumberTextbox is returned
            get { return callNumberTextbox.Text; }
            // Precondition:  None
            // Postcondition: Text in callNumberTextbox is set to specified value
            set { callNumberTextbox.Text = value; }
        }
        private void callNumberTextbox_Validating(object sender, CancelEventArgs e)
        {
            string text = callNumberTextbox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(callNumberTextbox, "Enter a Call Number"); // Set error message

                callNumberTextbox.SelectAll(); // Select all text in callNumberTextbox to ease correction
            }
        }
        // Precondition:  callNumberTextbox_Validating succeeded
        // Postcondition: Any error message set for callNumberTextbox is cleared
        //                Focus is allowed to change
        private void callNumberTextbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(callNumberTextbox, ""); // Clears error message
        }
        internal string BookAuthor// Can be accessed by other classes in same namespace

        { // Precondition:  None
            // Postcondition: Text in authorTextbox is returned
            get { return authorTextbox.Text; }
            // Precondition:  None
            // Postcondition: Text in authorTextbox is set to specified value
            set { authorTextbox.Text = value; }
        }

        // Precondition:  User has initiated click on cancelBtn
        // Postcondition: If left-click, textboxes are dismissed with Cancel result
        private void bookCancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
        
        // Precondition:  User has initiated click on OkBtn
        // Postcondition: If all controls on form validate, textboxes are dismissed with OK result
        private void bookOKButton_Click(object sender, EventArgs e)
        {
            {
                if (this.ValidateChildren())
                    this.DialogResult = DialogResult.OK;
            }
        }
    }

}
