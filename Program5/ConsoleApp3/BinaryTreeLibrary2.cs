// Grading ID: L5135
//Program 5-EC
//Due Date: 4/26/2019
//CIS 200-01
// Declaration of class TreeNode and class Tree.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
   // class TreeNode declaration to make this class generic and comprable 
    public class TreeNode<T> where T : IComparable<T>
    {
      // automatic property LeftNode
      //Precondition: This class must be generic
      //Post Condition: This will be autoimplemented
      public TreeNode<T> LeftNode { get; set; }

        // automatic property Data
       //Precondition: This class must be generic
       //Post Condition: This will be autoimplemented
        public IComparable Data { get; private set; }

        // automatic property RightNode
        //Precondition: This class must be generic
        //Post Condition: This will be autoimplemented
        public TreeNode<T> RightNode { get; set; }

      // initialize Data and make this a leaf node
      public TreeNode(IComparable nodeData)
      {
         Data = nodeData;
      }

      // insert TreeNode into Tree that contains nodes;
      // ignore duplicate values
      public void Insert(IComparable insertValue)
      {
         if (insertValue.CompareTo(Data) < 0) // insert in left subtree
         {
            // insert new TreeNode
            if (LeftNode == null)
            {
               LeftNode = new TreeNode<T>(insertValue);
            }
            else // continue traversing left subtree
            {
               LeftNode.Insert(insertValue);
            }
         }
         else if (insertValue.CompareTo(Data) > 0) // insert in right
         {
            // insert new TreeNode
            if (RightNode == null)
            {
               RightNode = new TreeNode<T>(insertValue);
            }
            else // continue traversing right subtree
            {
               RightNode.Insert(insertValue);
            }
         }
      }
   }

   // class Tree declaration
   public class Tree<T> where T : IComparable<T>
    {
      private TreeNode<T> root;

      // Insert a new node in the binary search tree.
      // If the root node is null, create the root node here.
      // Otherwise, call the insert method of class TreeNode.
      public void InsertNode(IComparable insertValue)
      {
         if (root == null)
         {
            root = new TreeNode<T>(insertValue);
         }
         else
         {
            root.Insert(insertValue);
         }
      }

      // begin inorder traversal
      public void InorderTraversal()
      {
         InorderHelper(root);
      }

      // recursive method to perform inorder traversal
      private void InorderHelper(TreeNode<T> node)
      {
         if (node != null)
         {
            // traverse left subtree
            InorderHelper(node.LeftNode);

            // output node data
            Console.Write($"{node.Data} ");

            // traverse right subtree
            InorderHelper(node.RightNode);
         }
      }

     

     
   }
}


