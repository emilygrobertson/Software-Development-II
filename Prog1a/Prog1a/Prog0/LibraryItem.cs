// Program 1a
// CIS 200-01
// By: L5135
// Due: 2/12/2019

// File: LibraryItem.cs
// This file creates various objects and variables that will be used in multiple derived classes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



public abstract class LibraryItem
{
    private string _title; //Backing Field for the Title
    private string _publisher; //Backing Field for the Publisher
    private int _copyrightYear; //Backing Field for the Copyright Year
    private int _loanPeriod; //Backing Field for the Load Period
    private string _callNumber; //Backing Field for the Call Number
    private bool _IsCheckedOut; //Backing Field for status: is checked out?

    public LibraryItem(string title, string publisher, int copyrightYear, int loanPeriod, string callNumber)
    {
        Title = title;
        Publisher = publisher;
        CopyrightYear = copyrightYear;
        LoanPeriod = loanPeriod;
        CallNumber = callNumber;
        Patron = null; //There is no Patron
        _IsCheckedOut = false;// The books must start out as "not checked out."
    }
    public LibraryPatron Patron
    { //Precondition: None
      //Postcondition: The books patron has been returned
        get;
        //Precondition: None
        //Postcondition: The book's patron has been set
        private set;// Auto-implement the set
    }

    public string Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }
        // Precondition:  value must not be null or empty
        // Postcondition: The title has been set to the specified value
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException
                    ($"{nameof(Title)}", value, $"{nameof(Title)} must not be null or empty");
            }
            else
                _title = value.Trim();
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
        // Precondition:  value must not be null or empty
        // Postcondition: The publisher has been set to the specified value
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException
                    ($"{nameof(Publisher)}", value, $"{nameof(Publisher)} must not be null or empty");
            }
            else
                _publisher = value.Trim();
        }
    }
    public string CallNumber
    {
        // Precondition:  None
        // Postcondition: The Call Number has been returned
        get
        {
            return _callNumber;
        }
        // Precondition:  value must not be null or empty
        // Postcondition: The Call NUmber has been set to the specified value
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException
                    ($"{nameof(CallNumber)}", value, $"{nameof(CallNumber)} must not be null or empty");
            }
            else
                _callNumber = value.Trim();
        }
    }
    public int LoanPeriod
    {
        // Precondition:  None
        // Postcondition: The loan period has been returned
        get
        {
            return _loanPeriod;
        }
        // Precondition:  value >= 0
        // Postcondition: The loan period has been set to the specified value
        set
        {
            if (value >= 0)
            {
                _loanPeriod = value;
            }
            else
                throw new ArgumentOutOfRangeException
                    ($"{nameof(LoanPeriod)}", value, $"{nameof(LoanPeriod)} can not be a negative value");
        }
    }
    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The Copyright Year has been returned
        get
        {
            return _copyrightYear;
        }
        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)
            {
                _copyrightYear = value;
            }
            else
                throw new ArgumentOutOfRangeException
                    ($"{nameof(CopyrightYear)}", value, $"{nameof(CopyrightYear)} can not be a negative value");
        }
    }
    public void CheckOut(LibraryPatron thePatron)
    {
        if (thePatron != null)
            Patron = thePatron;
        else
            throw new ArgumentOutOfRangeException($"{nameof(thePatron)}", $"{ nameof(thePatron)} can not be null");
        _IsCheckedOut = true;
    }

    public void ReturnToShelf()
    {
        Patron = null; //Remove the previously stored patron
        _IsCheckedOut = false;//Now the book is returned
    }
    public bool IsCheckedOut()
    {
        return _IsCheckedOut;
    }

    public abstract decimal CalcLateFee(int daysLate);
    protected void ValidateDaysLate(int daysLate)
    {
        if (daysLate < 0)
            throw new ArgumentOutOfRangeException
                      ($"{nameof(daysLate)}", daysLate, $"{nameof(daysLate)} can not be a negative value");

    }

    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut
        string checkedOutBy; // Holds checked out message

        if (IsCheckedOut())
            checkedOutBy = $"Checked Out By: {NL}{Patron}";
        else
            checkedOutBy = "Not Checked Out";

        return $"Title: {Title}{NL}Publisher: {Publisher}{NL}" +
            $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}{checkedOutBy}{NL}";
    }

}



