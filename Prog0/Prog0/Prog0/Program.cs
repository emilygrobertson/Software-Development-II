// Program 0
// Starting Point
//Grading Id: L5135
//Due date: 1/28/2019
//CIS 200-01
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
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2000, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            2016, "ZZ24 4F");    // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2001, "AE842 7A"); // 5th test book
        LibraryBook book6 = new LibraryBook("The life of Me", "Emily Robertson", "UofL Press", 2019, "RE308"); // 6th test book
        LibraryBook book7 = new LibraryBook("War and Peace", "Leo Totlstoy", "Best Books", 1988, "WE213"); // 7th test book
        LibraryBook book8 = new LibraryBook("It", "Stephen King", "Scary Books", 2012, "AQ567"); //8th test book
        LibraryPatron patron1 = new LibraryPatron("Emily Robertson", "1234");//Patron1
        LibraryPatron patron2 = new LibraryPatron("John Smith", "1345");//Patron2
        LibraryPatron patron3 = new LibraryPatron("Molly Jacobs", "1789");//Patron3
        
        //This is the list of Library Book objects that has replaced the array.
        var librarybooks = new List<LibraryBook>() { book1, book2, book3, book4, book5, book6, book7, book8 };
       
        WriteLine("Original list of books");
        WriteLine("----------------------");
        PrintBooks(librarybooks);
        Pause();

        // Make changes
        book1.CheckOut(patron1);
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(patron2);
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(patron3);
        //book5.CopyrightYear = -1234; // Attempt invalid year.This works successfully.

        WriteLine("After changes");
        WriteLine("-------------");
        PrintBooks(librarybooks);
        Pause();

        // Return the books
        book1.ReturnToShelf();
        book3.ReturnToShelf();
        book5.ReturnToShelf();

        WriteLine("After returning the books");
        WriteLine("-------------------------");
        PrintBooks(librarybooks);
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List<LibraryBook> books)
    {
        foreach (LibraryBook b in books)
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
