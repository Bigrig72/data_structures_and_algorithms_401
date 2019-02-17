using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.classes;

namespace HashTable.Classes
{
    public class HashTableSetup       
    {
        private LList[] Bucket { get; set; }
        private int _size;

        public HashTableSetup(int size)
        {
            Bucket = new LList[size];
            _size = size;
        }

        public int Hash(Object key)
        {
           string  Keystring = (string)key;
            long num = 1;
            foreach (char item in Keystring)
            {
                num *= item;
            }

            return (int)((num * 599) % _size);
        }

        public void Add(Object key, Object value)
        {
            int idx = Hash(key);

            if (Bucket[idx] == null)
            {
                Bucket[idx] = new LList();
            }
            if(Get(key) != null)
            {
                Bucket[idx].Append(key, value);
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

        public bool Contains(Object key, Object value)
        {
            int idx = Hash(key);
            Object returnedValue = Get(key);

            if (returnedValue == null)
            {
                return false;
            }
            if (returnedValue.Equals(value))
            {
                return true;
            }

            return false;
        }
    }
}
