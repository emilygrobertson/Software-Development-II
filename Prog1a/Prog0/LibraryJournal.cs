// Program 1a
// CIS 200-01
// By: L5135
// Due: 2/12/2019

// File: LibraryJournal.cs
// This file creates an IS-A relationship between LibraryJournal and LibraryPeriodical.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class LibraryJournal : LibraryPeriodical
    {
        private string _discipline;
        private string _editor;

        public LibraryJournal(string title, string publisher, int copyrightYear, int loanPeriod,
                         string callNumber, int volume, int number, string discipline, string editor)
                        : base(title, publisher, copyrightYear, loanPeriod, callNumber, volume, number)
        {
            Discipline = discipline;
            Editor = editor;
        }

     public string Discipline
        {
            // Precondition:  None
            // Postcondition: The discipline will be returned
            get
            {
                return _discipline;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The discipline has been set 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Discipline)}", value, $"{nameof(Discipline)} please enter a Discipline");
                else
                    _discipline = value.Trim();
            }
        }

      public string Editor
        {
            // Precondition:  None
            // Postcondition: The editor will be returned
            get
            {
                return _editor;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The editor has been set 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Editor)}", value, $"{nameof(Editor)} please enter an Editor");
                else
                    _editor = value.Trim();
            }
        }

        // Precondition:  None
        // Postcondition: A decimal is returned presenting the charge fee for a journal
        public override decimal CalcLateFee(int daysLate)
        {
            const decimal LATE_FEE = 0.75m;//daily rate for journal late fee
        decimal charge;//The charge ti be returned
        ValidateDaysLate(daysLate);
        charge = daysLate * LATE_FEE;
        return charge;
        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the LibraryJournal's object data on separate lines
        public override string ToString()
        {
        string NL = Environment.NewLine; // NewLine shortcut
        return $"Library Book:{NL}Discipline: {Discipline}{NL} Editor: {Editor}{NL}{base.ToString()}";
    }


    }

