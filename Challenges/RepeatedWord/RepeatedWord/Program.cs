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

            Console.WriteLine($"{RepeatedWord(input)}");
            Console.ReadLine();
            

        }

        public static string RepeatedWord(string repeatedWord)
        {
            string[] splitInput = repeatedWord.Split(' ', ',', ':', ';', '.');
            HashTableSetup table = new HashTableSetup(1024);

           int index;
            for (int i = 0; i < splitInput.Length; i++)
            {

              index = table.Hash(splitInput[i]);
                if (table.Contains(splitInput[i], index))
                {
                    return splitInput[i];
                }
                else
                {
                   table.Add(splitInput[i], index);
                }
            }
            return null;

        }
    }
}
