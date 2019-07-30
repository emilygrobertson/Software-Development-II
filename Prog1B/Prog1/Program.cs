// Program 1B
// CIS 200-01
// Due: 2/20/2019
// By: L5135

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;
using static System.Console;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
    public static void Main(string[] args)
    {
        const int DAYSLATE = 14; // Number of days late to test each object's CalcLateFee method
        const int ADDLOANPERIOD = 7; //The number of days added to loan period

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));//book1
        items.Add(new LibraryBook("To Kill a Mockingbird", "USA Press", 1996, 14, "UT23 R4", "Emily Robertson"));//book2
        items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));//movie1
        items.Add(new LibraryMovie("The Hills have Eyes", "USA Movies", 2018, 14, "MME3 8B", 108.5, "Andrew Smith", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.R));//movie2
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));//music1
        items.Add(new LibraryMusic("The Day it All Changed", "USA Music", 2011, 14, "CDGF V3", 67.8, "Alicia Keys", LibraryMediaItem.MediaType.CD, 12));//music2
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2017, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));//journal1
        items.Add(new LibraryJournal("Journal of an American Kiler", "USA Journals", 2008, 14, "4EW2 N7", 3, 5, "Mystery", "Macy Jones"));//journal2
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2019, 14,
            "MA53 9A", 16, 7));//magazine1
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA45 8T", 17, 5));//magazine2


        // Add patrons
        patrons.Add(new LibraryPatron("Ima Reader", "12345"));//patron1
        patrons.Add(new LibraryPatron("Jane Doe", "11223"));//patron2
        patrons.Add(new LibraryPatron("   John Smith   ", "   654321   "));//patron3
        patrons.Add(new LibraryPatron("Emily Robertson", "22335"));//patron4
        patrons.Add(new LibraryPatron("Molly Hehn", "66558"));//patron5

        //Start by displaying the items
        Console.WriteLine("List of items at start:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        Pause();//pause until the user hits enter


        // Check out some items
        items[3].CheckOut(patrons[0]);
        items[2].CheckOut(patrons[2]);
        items[9].CheckOut(patrons[1]);

        //Display the list of items that are checked out
        WriteLine("List of items after checking some out:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        Console.WriteLine("Items that are checked out:\n");
        var checkedout =
       from l in items
       where l.IsCheckedOut() == true
       select l;
        //Display the count of items that are checked out
        foreach (var l in checkedout)
        {
            Console.WriteLine(l);
            Console.WriteLine();
        }
        Console.WriteLine("\n\nCount of checked out items: {0}", checkedout.Count());

        Pause();//pause until the user hits enter

        //Display the Media Items that are checked out
        Console.WriteLine("Media Items that are Checked Out: \n");
        var outputmedia =
       from m in checkedout
       where m is LibraryMediaItem 
       select m;

        foreach (var m in outputmedia)
        {
            Console.Write("{0}\n", m);
            Console.WriteLine();
        }
        Pause();//pause until the user hits enter

        //Display the Unique magazine titles
        //Postcondition: This should display only one title if two titles have the same name
        Console.WriteLine("Unique magazine titles:\n");
        var uniquetitles =
            from n in items
            where n is LibraryMagazine
            select n.Title;
        foreach (var n in uniquetitles.Distinct())
        {
            Console.WriteLine(n);
            Console.WriteLine();
        }
        Pause();//pause until the user hits enter

       
        WriteLine($"Calculated late fees after {DAYSLATE} days late:\n");
        WriteLine($"{"Title",30} {"Call Number",11} {"Late Fee",8}");
        WriteLine("------------------------------ ----------- --------");

        // Caluclate and display late fees for each item after 14 days
        foreach (LibraryItem item in items)
            WriteLine($"{item.Title,30} {item.CallNumber,11} {item.CalcLateFee(DAYSLATE),8:C}");
        Pause();//pause until the user hits enter

        //Return the previous items that were checked out
        items[3].ReturnToShelf();
        items[2].ReturnToShelf();
        items[9].ReturnToShelf();

        //display the count of checked out items with the linq result variable
        //Postcondition: The count should be 0
        Console.WriteLine("\n\n\nCount of checked out items: {0}", checkedout.Count());
        Pause();//pause until the user hits enter

        //This calculates the new loan period for each item
        foreach (var p in items)
        {
            Console.Write($"This is the current loan period for {p.Title}: ");
            Console.WriteLine(p.LoanPeriod);
            Console.Write("This is the loan period plus 7 days: ");
            Console.WriteLine((p.LoanPeriod=p.LoanPeriod+ ADDLOANPERIOD));
            Console.WriteLine();
        }
        Pause();
        //This displays all items once again
        foreach (var item in items)
            Console.Write("\n {0}\n", item);
        Pause();//pause until the user hits enter


    }

        
    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        WriteLine("Press Enter to Continue...");
        ReadLine();

        Clear(); // Clear screen
    }
}