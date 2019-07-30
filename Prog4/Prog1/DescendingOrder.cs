// Program 4
// CIS 200-01
// Due: 4/17/2019
// By: L5135

// File: DescendingOrder.cs
// This file compare two items by Copyright Year in Descending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    public class DescendingOrder : Comparer<LibraryItem>
    {
        // Precondition:  None
        // Postcondition: Reverses natural time order, so descending
        //                When item11 < item2, method returns positive #
        //                When item1 == item2, method returns zero
        //                When item1 > item2, method returns negative #
        public override int Compare(LibraryItem item1, LibraryItem item2)
        {
            // Ensure correct handling of null values (in .NET, null less than anything)
            if (item1 == null && item2 == null) //Both null?
                return 0; //Equal
            if (item1 == null) //only item1 null?
                return -1; //null is less than actual item
            if (item2 == null)//only item2 null?
                return 1;//actual item is greater than null
            return (-1) * item1.CopyrightYear.CompareTo(item2.CopyrightYear);// Reverses natural order, so descending


        } 
    }
}
