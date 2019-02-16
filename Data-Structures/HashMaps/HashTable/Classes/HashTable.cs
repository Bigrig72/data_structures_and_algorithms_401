using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.classes;

namespace HashTable.Classes
{
    public class HashTable       
    {
        private LList[] Bucket { get; set; }
        private int _size;

        public HashTable(int size)
        {
            Bucket = new LList[size];
            _size = size;
        }

        public int Hash(Object key)
        {
           string  Keystring = (string)key;
            int num = 1;
            foreach (char item in Keystring)
            {
                num *= item;
            }
            return num % _size;
        }

        public void Add(Object key, Object value)
        {
            int idx = Hash(key);
            if (Bucket[idx] == null)
            {
                Bucket[idx] = new LList();
            }
            if(Get(key) == null)
            {
                Bucket[idx].Append(new Node (key, value));
            }
        }

        public Object Get(Object key)
        {
            int idx = Hash(key);
            if (Bucket[idx] == null)
            {
                return null;
            }
            return Bucket[idx].Current.Value;
            
        }

        public bool Contains(Object Key, Object value)
        {

        }
    }
}
