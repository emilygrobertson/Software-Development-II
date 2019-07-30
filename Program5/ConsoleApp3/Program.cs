// Grading ID: L5135
//Program 5-EC
//Due Date: 4/26/2019
//CIS 200-01
// Test Data is in this class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test data
            int[] intArray = { 2, 4, 7, 8, 3, 9, 0, 1, 5, 6 };
            double[] doubleArray = { 8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6, 9.9, 1.1 };
            string[] stringArray =
               {"eight", "two", "four","three", "one", "seven", "five", "six", "nine","ten"};

            // create int Tree
            Tree<int> intTree = new Tree<int>();
            Console.WriteLine($"\n\n\nInserting into {nameof(intTree)}:");
           
            foreach (IComparable data in intArray)
            {
                Console.Write($"{data} ");
                intTree.InsertNode(data);
            }
            
            // perform inorder traversal of tree
            Console.WriteLine($"\n\nInorder traversal of {nameof(intTree)}");
            intTree.InorderTraversal();
            Pause();

            // create double Tree
            Tree<double> doubleTree = new Tree<double>();
            Console.WriteLine($"\n\n\nInserting into {nameof(doubleTree)}:");

            foreach (IComparable data in doubleArray)
            {
                Console.Write($"{data} ");
                doubleTree.InsertNode(data);
            }
            // perform inorder traversal of tree
            Console.WriteLine($"\n\nInorder traversal of {nameof(doubleTree)}");
            doubleTree.InorderTraversal();
            Pause();

            // create string Tree
            Tree<string> stringTree = new Tree<string>();
            Console.WriteLine($"\n\n\nInserting into {nameof(stringTree)}:");

            foreach (IComparable data in stringArray)
            {
                Console.Write($"{data} ");
                stringTree.InsertNode(data);
            }
            // perform inorder traversal of tree
            Console.WriteLine($"\n\nInorder traversal of {nameof(stringTree)}");
            stringTree.InorderTraversal();
            Pause();

            
        }
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            Console.Clear();  //Clears the screen
        }
    }
    
}

