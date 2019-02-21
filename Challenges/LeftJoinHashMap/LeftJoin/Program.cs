using System;
using System.Collections.Generic;
using HashTable.Classes;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTableSetup table1 = new HashTableSetup(1024);
            HashTableSetup table2 = new HashTableSetup(1024);

            List<string> Keys = new List<string>();


            table1.Add("fond", "enamored");
            table1.Add("wrath", "anger");
            table1.Add("diligent", "employed");
            table1.Add("outift", "garb");
            table1.Add("guide", "usher");

            table2.Add("fond", "averse");
            table2.Add("wrath", "delight");
            table2.Add("diligent", "idle");
            table2.Add("guide", "follow");
            table2.Add("flow", "jam");

        }

        public static Array LeftJoin(HashTableSetup table1, HashTableSetup table2)
        {
            List<Array> final = new List<Array>();
            
            

            List<string> values = new List<string>();

                values.Add(key1);
                


            return ;

        }
    }
}