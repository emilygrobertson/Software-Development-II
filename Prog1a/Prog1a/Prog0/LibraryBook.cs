// Program 0
// CIS 200-01
// By: Andrew L. Wright (Student's use Grading ID)
// Due: 1/28/2019

// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.
// Added HAS-A with LibraryPatron
// Removed bool backing field for checked out status

// Program 1a
// CIS 200-01
// By: L5135
// Due: 2/12/2019

// File: LibaryBook.cs
// This file creates an IS-A relationship between LibraryBook and LibraryItem.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook : LibraryItem
{
    private string _author;


    public LibraryBook(string title, string author, string publisher, int copyrightYr,
           int loanPd, string callNum)
        : base(title, publisher, copyrightYr, loanPd, callNum)
    {
        Author = author;

    }

    public string Author
    {
        // Precondition:  None
        // Postcondition: The author will be returned
        get
        {
            return _author;
        }
        // Precondition:  None
        // Postcondition: The author has been set
        set
        {

            _author = (value == null ? string.Empty : value.Trim());
        }
    }

    public override decimal CalcLateFee(int daysLate)
    {

        const decimal LATE_FEE = 0.25m;//late fee for all Library books
        decimal charge;// charge fee to be returned
        ValidateDaysLate(daysLate);
        charge = daysLate * LATE_FEE;
        return charge;
    }

    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut
        return $"Library Book:{NL}Author: {Author}{NL}{base.ToString()}";

        
    }
}













    
