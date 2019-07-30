// Program 1a
// CIS 200-01
// By: L5135
// Due: 2/12/2019

// File: LibraryMagazine.cs
// This file creates an IS-A relationahip between LibaryMagazine and LibraryPeriodical.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class LibraryMagazine: LibraryPeriodical
    {
        public LibraryMagazine(string title, string publisher, int copyrightYr, int loanPd,
                        string callNum, int volume, int number)
                       : base(title, publisher, copyrightYr, loanPd, callNum, volume, number)
        {

        }
    // Precondition:  None
    // Postcondition: A decimal is returned presenting the charge fee for a magazine
    public override decimal CalcLateFee(int daysLate)
    {
        const decimal LATE_FEE = 0.25m;//daily rate for magazine late fee
        const decimal MAX_CHARGE = 20m;// max limit for all magazine types
        decimal charge;  // the charge fee to be returned
        ValidateDaysLate(daysLate);
        if (daysLate <= MAX_CHARGE)
        { charge = daysLate * LATE_FEE;
            return charge; }
        else
            throw new ArgumentOutOfRangeException
                           ($"{nameof(daysLate)}", daysLate, $"{nameof(daysLate)} please enter a valid number of days");
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the LibraryMagazine's object data on separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut
        return base.ToString();

    }





    }

