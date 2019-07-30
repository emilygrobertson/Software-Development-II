// Program 1a
// CIS 200-01
// By: L5135
// Due: 2/12/2019

// File: LibaryMovie.cs
// This file creates an IS-A relationship between LibraryMovie and LibraryMediaItem.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


   public  class LibraryMovie : LibraryMediaItem
    {
        private string _director;   //Backing field for the director
        private MPAARatings _rating;    //Backing filed for the rating
        public enum MPAARatings { G, PG, PG13, R, NC17, U };

        public LibraryMovie(string title, string publisher, int copyrightYr, int loanPd,
                            string callNum, double duration, string director, MediaType medium,
                            MPAARatings rating)
                            : base(title, publisher, copyrightYr, loanPd,
                                  callNum, duration)
        {
            Director = director; 
        }

        public string Director
        {
            // Precondition:  None
            // Postcondition: The director will be returned
            get
            {
                return _director;
            }

            set
            {
                // Precondition:  value can not be null or empty
                // Postcondition: The director has been set
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Director)}", value, $"{nameof(Director)} please enter a Director");
                else
                    _director = value.Trim();
            }
        }

        public override MediaType Medium
        {
            // Precondition: Medium must be of type DVD/VHS/BLURAY only
            // Postcondition: The medium has been set
            get
            {
                return _medium;
            }

            set
            {
                // conditional for DVD, BLURAY, and VHS 
                if (value == MediaType.DVD || value == MediaType.BLURAY || value == MediaType.VHS)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Medium)}", value, $"{nameof(Medium)} please enter a valid medium for a movie");

            }

        }

        public MPAARatings Rating
        {
            get
            {
                return _rating;
            }

            set
            {

                
                if (value == MPAARatings.G || value == MPAARatings.PG || value == MPAARatings.PG13 ||
                   value == MPAARatings.R || value == MPAARatings.NC17 || value == MPAARatings.U)
                {
                    _rating = value;
                }
                else
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(Rating)}", value, $"{nameof(Rating)} please enter a valid MPAA rating");
            }
        }

    public override decimal CalcLateFee(int daysLate)
    {

        const decimal LATE_FEE_BLURAY = 1.50m; // Bluray daily rate
        const decimal LATE_FEE_DVD_VHS = 1.00m; // DVD/VHS daily rate
        const decimal MAX_CHARGE = 25.00m; // max limit for all movie types
        decimal charge; // the charge fee to be returned
        ValidateDaysLate(daysLate);
        if (this.Medium == MediaType.DVD)
        {
            if (daysLate * LATE_FEE_DVD_VHS >= MAX_CHARGE)
            {
                charge = MAX_CHARGE;
            }
            else
                charge = daysLate * LATE_FEE_DVD_VHS;
        }

        else
        {
            if (daysLate * LATE_FEE_BLURAY >= MAX_CHARGE)
            {
                charge = MAX_CHARGE;
            }
            else
                charge = daysLate * LATE_FEE_BLURAY;
        }

        return charge; 
        

    }

    public override string ToString()
    {

        string NL = Environment.NewLine; // NewLine shortcut
        return $"Library Book:{NL}Director: {Director}{NL} Ratings: {Rating}{NL} {base.ToString()}";
    }










    }

