using System;
using System.Text.RegularExpressions;
using HashTable.Classes;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "Once upon a time, there was a brave who...";

            Console.WriteLine($"{RepeatedWords(input)}");
            Console.ReadLine();
            

        }
        /// <summary>
        /// This function will first split our word by all delimeters specified. 
        /// We will then create a hash table and hash each word that is split.
        /// If the word is contained withing the linked list it will return that value, if not
        /// we will add it to the linked list
        /// </summary>
        /// <param name="repeatedWord"></param>
        /// <returns></returns>
        public static string RepeatedWords(string repeatedWord)
        {
            string[] splitInput = repeatedWord.Split(' ', ',', ':', ';', '.');
            HashTableSetup table = new HashTableSetup(1024);

           int index;
            for (int i = 0; i < splitInput.Length; i++)
            {

              index = table.Hash(splitInput[i].ToLower());
                if (table.Contains(splitInput[i].ToLower(), index))
                {
                    return splitInput[i].ToLower();
                }
                else
                {
                   table.Add(splitInput[i].ToLower(), index);
                }
            }
            return null;

        }
    }
}
