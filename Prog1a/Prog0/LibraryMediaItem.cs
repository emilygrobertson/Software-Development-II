using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class LibraryMediaItem : LibraryItem
{
    private double _duration;
    protected MediaType _medium;  //Backing field for the medium

    public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL };

    public LibraryMediaItem(string title, string publisher, int copyrightYr, int loanPd,
                            string callNum, double duration)
                            : base(title, publisher, copyrightYr, loanPd, callNum)
    {
        Duration = duration;
    }

    public double Duration
    {
        get
        {
            return _duration;
        }

        set
        {
            if (value >= 0)
                _duration = value;
            else
                throw new ArgumentOutOfRangeException
                    ($"{nameof(Duration)}", value, $"{nameof(Duration)} must be greater than or equal to zero");
        }
    }




    public abstract MediaType Medium { get; set; }



    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut
        return $"Library Book:{NL}Duration: {Duration}{NL} Medium: {Medium}{NL}{base.ToString()}";
    }

}


        
    


