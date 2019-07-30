// Program 1a
// CIS 200-01
// By: L5135
// Due: 2/12/2019

// File: LibraryPeriodical.cs
// This file creates an IS-A relationship between LibraryPeriodical and LibraryItem.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    public abstract class LibraryPeriodical : LibraryItem
    {
        private int _volume; //Backing for volume
        private int _number; //Backing for number

        public LibraryPeriodical(string title, string publisher, int copyrightYear, int loanPeriod,
                                 string callNumber, int volume, int number)
                                : base(title, publisher, copyrightYear, loanPeriod, callNumber)
        {

            Volume = volume;
            Number = number;
        }

        public int Volume
        {
            // Precondition:  None
            // Postcondition: The volume will be returned
            get
            {
                return _volume;
            }
            // Precondition:  value >= 1
            // Postcondition: The volume has been set 
            set
            {
                if (value >= 1)
                    _volume = value;
                else
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Volume)}", value, $"{nameof(Volume)} must be greater than or equal to one");
            }
        }

        public int Number
        { // Precondition:  None
          // Postcondition: The number will be returned
            get
            {
                return _number;
            }
            // Precondition:  value >= 1
            // Postcondition: The number has been set 
            set
            {
                if (value >= 1)
                    _number = value;
                else
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Number)}", value, $"{nameof(Number)} must be greater than or equal to one");
            }

        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the LibraryPeriodical object data on separate lines
        public override string ToString()
        {
        string NL = Environment.NewLine; // NewLine shortcut
        return $"Library Book:{NL}Volume: {Volume}{NL}Number: {Number}{NL}{base.ToString()}";
    }
    }

