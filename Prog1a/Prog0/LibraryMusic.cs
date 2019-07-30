// Program 1a
// CIS 200-01
// By: L5135
// Due: 2/12/2019

// File: LibraryMusic.cs
// This file creates an IS-A relationship between LibraryMusic and LibraryMediaItem.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    public class LibraryMusic : LibraryMediaItem
    {
        private string _artist;   //Backing field for the artist
        
        private int _trackNumber; //Backing field for the track number
         
        public LibraryMusic(string title, string publisher, int copyrightYear, int loanPeriod,
                            string callNumber, double duration, string artist, MediaType medium,
                            int trackNumber)
                            : base(title, publisher, copyrightYear, loanPeriod,
                                  callNumber, duration)
        {
            Artist = artist;
            TrackNumber = trackNumber;
        }

        public string Artist
        {
            // Precondition:  None
            // Postcondition: The director will be returned
            get
            {
                return _artist;
            }

            set
            {
                // Precondition:  value can not be null or empty
                // Postcondition: The director has been set
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Artist)}", value, $"{nameof(Artist)} please enter a Director");
                else
                    _artist = value.Trim();
            }
        }

        public override MediaType Medium
        {
            // Precondition: Medium must be of type DVD/VHS/BLURAY only
            // Postcondition: The medium has been set to the specified value
            get
            {
                return _medium;
            }

            set
            {
                // conditional for DVD, BLURAY, and VHS only???
                if (value == MediaType.CD || value == MediaType.SACD || value == MediaType.VINYL)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Medium)}", value, $"{nameof(Medium)} please enter a valid medium for a movie");

            }

        }

        public int TrackNumber
        {
            get
            {
                return _trackNumber;
            }

            set
            { 
                if (value >= 0)
                {
                    _trackNumber = value;
                }
                else
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(TrackNumber)}", value, $"{nameof(TrackNumber)} can not be a negative value");
            }
        }
    public override decimal CalcLateFee(int daysLate)
    {
        const decimal LATE_FEE = 0.5m;//daily rate for music late fee
        const decimal MAX_CHARGE = 20m;// max limit for all music types
        decimal charge;  // the charge fee to be returned
        ValidateDaysLate(daysLate);
        if (daysLate <= MAX_CHARGE)
        {
            charge = daysLate * LATE_FEE;
            return charge;
        }
        else
            throw new ArgumentOutOfRangeException
                           ($"{nameof(daysLate)}", daysLate, $"{nameof(daysLate)} please enter a valid number of days");
    }
        // Precondition:  None
        // Postcondition: A string is returned presenting the LibraryMusic object data on separate lines
        public override string ToString()
        {
        string NL = Environment.NewLine; // NewLine shortcut
        return $"Library Book:{NL}Artist: {Artist}{NL} Medium: {Medium}{NL}Track Number: {TrackNumber}{NL} {base.ToString()}";
    }














    }

