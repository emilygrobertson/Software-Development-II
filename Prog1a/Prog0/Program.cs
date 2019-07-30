// Program 1a
// CIS 200-01
// By: L5135
// Due: 2/12/2019

// File: Program.cs
// This file creates a simple test application class that creates
// an array of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

public class Program
{
    
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {

        const int DAYSLATE = 5; // Number of days late to test each object's CalcLateFee method

        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press", 2010, 2, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books", 2000, 3, "AG773 ZF"); // 2nd test book
        LibraryMovie movie1 = new LibraryMovie("The Hills have Eyes", "Emily Robertson", 2010, 10, "AA232", 2.0, "Molly Simmins", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G); //1st test movie
        LibraryMovie movie2 = new LibraryMovie("The Child", "Tom Boyd", 2019, 10, "A0U32", 1.0, "Sean Smith", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.R); //2nd test movie
        LibraryJournal journal1 = new LibraryJournal("The Wall Street Journal", "The NY Press", 2016, 10, "WW234", 3, 5, "Business", "John Smith");//1st test journal
        LibraryJournal journal2 = new LibraryJournal("The New Yorker", "The NY Press", 2018, 10, "W9234", 7, 12, "Business", "Yolanda Rogers");//2nd test journal
        LibraryMusic music1 = new LibraryMusic("Theory of a Deadman", "The Press", 2018, 10, "QW234", 34.67, "Theory of a Deadman", LibraryMediaItem.MediaType.CD, 5);// 1st test music
        LibraryMusic music2 = new LibraryMusic("Kids Bop 45", "The Kidz", 2019, 10, "XC234", 56.67, "KIDS Inc.", LibraryMediaItem.MediaType.CD, 8);// 2nd test music
        LibraryMagazine magazine1 = new LibraryMagazine("Gossip Central", "Teen Vogue", 2015, 10, "TT189", 7, 6);//1st test magazine
        LibraryMagazine magazine2 = new LibraryMagazine("People", "The Press", 2019, 10, "KJ189", 9, 2);//2nd test magazine

        LibraryPatron patron1 = new LibraryPatron("Ima Reader", "123456"); // 1st test patron
        LibraryPatron patron2 = new LibraryPatron("Jane Doe", "112233");  // 2nd test patron
        LibraryPatron patron3 = new LibraryPatron("   John Smith   ", "   654321   "); // 3rd test patron - Trims?
        LibraryPatron patron4 = new LibraryPatron("Jessie Hehn", "234567"); // 4th test patron
        LibraryPatron patron5 = new LibraryPatron("AJ Ross", "654321"); // 5th test patron


        List<LibraryItem> theLibraryItems = new List<LibraryItem> { book1, book2, movie1, movie2, journal1, journal2, music1, music2, magazine1, magazine2 }; // Test list of books, movies, journals,music,and magazines

        WriteLine("Original list of books");
        WriteLine("----------------------");
        PrintItems(theLibraryItems);
        Pause();


        foreach (LibraryItem item in theLibraryItems)
            WriteLine($"{item.Title,30} {item.CallNumber,11} {item.CalcLateFee(DAYSLATE),8:C}");
        Pause();

    }

        // Precondition:  None
        // Postcondition: The books have been printed to the console
        public static void PrintItems(List<LibraryItem> items)
        {
            foreach (LibraryItem b in items)
            {
                WriteLine(b);
                WriteLine();
            }
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

