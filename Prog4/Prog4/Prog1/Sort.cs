// Program 4
// CIS 200-01
// Due: 4/17/2019
// By: L5135

// File: Sort.cs
// This file compare two items by Title and Type in Ascending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    public class Sort: Comparer<LibraryItem>
    {
        // Precondition:  None
        // Postcondition: Ascending Order
        //                When item11 == null, method returns 1
        //                When item1 == item2, method returns the compared value
        public override int Compare(LibraryItem item1, LibraryItem item2)
        {
            if (item1 == null) // only item1 is null?
                return 1;   // equals 1


            if (item1.GetType() == (item2.GetType()))//Item1 and Item2 are equal
                return item1.CompareTo(item2);       //Then compare them 
            else
                return (item1.GetType().ToString().CompareTo(item2.GetType().ToString())); // compare the types of item1 to item2 by making them strings

        }
    }
}
