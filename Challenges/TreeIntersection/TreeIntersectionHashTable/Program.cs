using System;
using System.Collections.Generic;
using Trees.Classes;
using HashTable.Classes;

namespace TreeIntersectionHashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Binary Tree");
            BinaryTree root = new BinaryTree();
            root.Top = new Node(40);
            root.Top.Left = new Node(20);
            root.Top.Right = new Node(30);
            root.Top.Left.Left = new Node(25);
            root.Top.Left.Right = new Node(35);
            root.Top.Right.Left = new Node(10);
            root.Top.Right.Right = new Node(19);

            Console.WriteLine("Test Binary Tree");
            BinaryTree root2 = new BinaryTree();
            root2.Top = new Node(35);
            root2.Top.Left = new Node(90);
            root2.Top.Right = new Node(30);
            root2.Top.Left.Left = new Node(19);
            root2.Top.Left.Right = new Node(55);
            root2.Top.Right.Left = new Node(10);
            root2.Top.Right.Right = new Node(50);

            List<int> list1 = new List<int>();

            List<int> list2 = new List<int>();

            List<int> final = TreeIntersection(list1, list2, root, root2);

            foreach (var item in final)
            {
            Console.WriteLine($" Repeating values: {item}"); 

            }
        }
        /// <summary>
        /// This method wil take in 2 lists that will store the preordered binary trees. 
        ///  Next the values at each tree are hashed into the hash table.
        ///  The first for loop will add the first list into the hash table
        ///  The second list we will create a index for the hash table 
        ///  We will do a check using the contains method to see if both values that were hashed are contained in the table
        ///  If they are contained we add to the new final list, otherwise add to table
        /// </summary>
        /// <param name="storedTreeValues"></param>
        /// <param name="storedTreeValues2"></param>
        /// <param name="tree1"></param>
        /// <param name="tree2"></param>
        /// <returns></returns>
        public static List<int> TreeIntersection(List<int> storedTreeValues, List<int> storedTreeValues2, BinaryTree tree1, BinaryTree tree2)
        {
            // Setting up tree 1 iteration to final list
            HashTableSetup table = new HashTableSetup(1024);
            tree1.PreOrder(tree1.Top, storedTreeValues);
            tree2.PreOrder(tree2.Top, storedTreeValues2);

            List<int> finalList = new List<int>();

            int index;

            for (int i = 0; i < storedTreeValues.Count; i++)
            {
                table.Add(storedTreeValues[i].ToString(), storedTreeValues[i].ToString());

                 for (int j = 0; j < storedTreeValues2.Count; j++)
                 {
                    index = table.Hash(storedTreeValues2[j].ToString());
                    if(table.Contains(storedTreeValues2[j].ToString(), index) && table.Contains(storedTreeValues[i].ToString(), index))
                    {
                        finalList.Add(storedTreeValues2[j]);
                    }
                    else
                    {
                        table.Add(storedTreeValues2[j].ToString(), index);
                    }
                 }
            }
            return finalList;
        }        
    }
}
