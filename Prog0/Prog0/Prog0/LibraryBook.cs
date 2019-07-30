// Program 0
// Starting point
//Grading Id:L5135
//Due date: 1/28/2019
//CIS 200-01
// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public readonly int DEFAULT_YEAR = DateTime.Now.Year; // Default copyright year is current year

    private string _title;      // The book's title
    private string _author;     // The book's author
    private string _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private string _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status
    private LibraryPatron _libraryPatron;
    // Precondition:  theCopyrightYear >= 0
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber)
    {
        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;
        _libraryPatron = null;

        ReturnToShelf(); // Make sure book is not checked out
    }

    public string Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition:  None
        // Postcondition: The title has been set to the specified value
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _title = value.Trim();
            else throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Title)}, Invalid Value");
        }
    }

    public string Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            _author = value;
        }
    }

    public string Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return _publisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            _publisher = value;
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return _copyrightYear;
        }

        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)
                _copyrightYear = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value),value,$"{nameof(CopyrightYear)}, Invalid Value");
        }
    }

    public string CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return _callNumber;
        }

        // Precondition:  None
        // Postcondition: The call number has been set to the specified value
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _callNumber = value.Trim();
            else throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CallNumber)}, Invalid Value");
        }
    }

    // Precondition:  None
    // Postcondition: The book is checked out
    public void CheckOut( LibraryPatron patron)
    {
        _checkedOut = true;
        _libraryPatron = patron;
    }

    // Precondition:  None
    // Postcondition: The book is not checked out
    public void ReturnToShelf()
    {
        _checkedOut = false;
        _libraryPatron = null;
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
    }

    public LibraryPatron Patron
    { //Precondition: The book must currently be checked out.
      //Postcondition: None
        get
        {
            return _libraryPatron;
        }
    }
    // Precondition:  None
    // Postcondition: A string is returned representing the libary book's
    //                data on separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // Newline shortcut
        string conditional;
        if (IsCheckedOut())
            conditional = $"Checked Out By: {Patron.PatronName}ID number: {Patron.PatronID}"; //This is retriving the patron ID and name.
        else
            conditional= $"Not Checked Out";

        return $"Title: {Title}{NL}Author: {Author}{NL}Publisher: {Publisher}{NL}" +
                $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}" +
               conditional;
    } 
}
