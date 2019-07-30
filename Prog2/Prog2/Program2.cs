//Grading ID: L5135
//Program 2
//Due Date: 3/10/2019
//CIS 200-01
//This form contains our test data and will be used for all parts of the program.
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
    public partial class Program2 : Form
    {
        private Library _lib; //The Library Object
        //Precondition: None
        //Postcondition: Books and Patrons will be displayed in the GUI
        public Program2()
        { //Precondition: none
          //Postcondition: The Program2 Form GUI is initialized
            InitializeComponent();
            _lib = new Library(); 

            //Insert Test Data
            _lib.AddLibraryBook("The Hills Have Eyes", "UofL Press", 2010, 20, "44RTW", "Dr.Wright");
            _lib.AddLibraryBook("To Kill a Mockingbird", "NY Press", 1998, 20, "46RYW", "Moll Happerns");
            _lib.AddLibraryMovie("The Color Purple", "Movies Press", 1987, 21, "TT432", 1.23, "Logan Jones", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.PG13);
            _lib.AddLibraryMovie("101 Dalmations", "Kids Movies Press", 1956, 21, "HE321", 2.15, "Jessie James", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.G);
            _lib.AddLibraryJournal("Journal of Teen Fashion", "Teen Press", 2019, 14, "PPO98", 4, 6, "Fashion", "Jimmy Richards");
            _lib.AddLibraryJournal("Journal of Calculus", "Math Press", 2001, 14, "DEO48", 10, 7, "Math", "Caroline Henderson");
            _lib.AddLibraryMagazine("Vogue", "Fashion Press", 2013, 20, "IU74W", 3, 12);
            _lib.AddLibraryMagazine("NascarRaces", "Cars Press", 2004, 20, "FG487", 5, 7);
            _lib.AddLibraryMusic("The Sound of Music", "Broadway Classics", 1996, 14, "890TR", 4.67, "Various Artists", LibraryMediaItem.MediaType.CD, 4);
            _lib.AddLibraryMusic("The Story of My Life", "Music Producers Inc.", 2007, 14, "CCS23", 1.55, "One Direction", LibraryMediaItem.MediaType.CD, 12);

            //Add 5 Patrons
            _lib.AddPatron("Emily Robertson", "987EE");
            _lib.AddPatron("Molly Baldock", "PP901");
            _lib.AddPatron("Jessie Hehn", "87TRE");
            _lib.AddPatron("Akansha Gupta", "3WQ12");
            _lib.AddPatron("Maddie Bloemer", "54RFC1");
        }
        //Precondition: none
        //Postcondition: This will exit the application if you click the Exit item on the menu.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Precondition: none
        //Postcondition: This will use the Patron form to allow users to input new patrons and return them onto a report.
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm inputForm = new PatronForm();
            DialogResult result = inputForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = inputForm.PatronName;
                string ID = inputForm.PatronID;
                _lib.AddPatron(name, ID);

            }

        }
        //Precondition: none
        //Postcondition: This will use the Book form to allow the user to input new books and return them onto a report.
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm inputForm = new BookForm();
            DialogResult result = inputForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string title = inputForm.BookTitle;
                string author = inputForm.BookAuthor;
                string callNumber = inputForm.BookCallNumber;
                string loanPeriod = inputForm.BookLoanPeriod;
                string copyrightYear = inputForm.BookCopyrightYear;

            }
        }

        //Precondition: none
        //Postcondition: This will count the number of patrons.
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut
            mainTextbox.Clear();
            foreach (LibraryPatron patron in _lib._patrons)
            {
                mainTextbox.AppendText($"{patron}{NL}{NL}");
            }
            mainTextbox.AppendText($"There are {_lib._patrons.Count} patrons");
        }
        //Precondition: none
        //Postcondition: This will count the number of library items.
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut
            mainTextbox.Clear();
            foreach (LibraryItem item in _lib._items)
            {
                mainTextbox.AppendText($"{item}{NL}{NL}");
            }
            mainTextbox.AppendText($"There are {_lib._items.Count} items.");
        }
        //Precondition: none
        //Postcondition: This will count the number of library books that are checked out.
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int checkedoutcount = 0;
            string NL = Environment.NewLine; // NewLine shortcut
            mainTextbox.Clear();
            foreach (LibraryItem item in _lib._items)
            {
                if (item.IsCheckedOut())
                {
                    mainTextbox.AppendText($"{item}{NL}{NL}");
                    ++checkedoutcount;
                }
            }
            mainTextbox.AppendText($"There are {checkedoutcount} items checked out.");
        }
        //Precondition: none
        //Postcondition: This will check out any books and output the information onto the Checked Out Report.
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut inputForm = new CheckOut(_lib._items, _lib._patrons);
            DialogResult result = inputForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                int patronIndex = inputForm.PatronIndex;
                string callNo = inputForm.CallNumber;
                int itemindex=-1;
                for (int x = 0; x < _lib._items.Count; ++x) // this for loop is used to make sure the user can't check out a book that is checked out by another patron.
                {
                    if(_lib._items[x].CallNumber == callNo)
                    {
                        itemindex = x;
                    }
                }
                if(itemindex>-1)
                    _lib.CheckOut(itemindex, patronIndex);
            }
        }
        //Precondition: none
        //Postcondition: This will return any books and output the information onto the Return Report.
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return inputForm = new Return(_lib._items);
            DialogResult result = inputForm.ShowDialog();
            if (result == DialogResult.OK)
            {
               
                string callNo = inputForm.CallNumber;
                int itemindex = -1;
                for (int x = 0; x < _lib._items.Count; ++x)//This for loop is used to make sure the user can't return a book that is not  checked out.
                {
                    if (_lib._items[x].CallNumber == callNo)
                    {
                        itemindex = x;
                    }
                }
                if (itemindex > -1)
                    _lib.ReturnToShelf(itemindex);
            }
        }
        //Precondition: none
        //Postcondition: This will give the user data about the Program.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut
            MessageBox.Show($"Grading ID: L5135 {NL} Program #2 {NL} Due Date: 3/10/2019 {NL}");
        }
    }
}
