using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.classes;

namespace HashTable.Classes
{
    public class HashTableSetup       
    {/// <summary>
    /// Creating a empty array for wht will be our hash table
    /// </summary>
        public LList[] Bucket { get; set; }
        public int _size;

        public HashTableSetup(int size)
        {
            Bucket = new LList[size];
            _size = size;
        }
        /// <summary>
        /// Here we are creating a so called encrypting way of finding a index for our Key value to be stored in the Buckets array
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Checking to see if that index is null, if so create a new linked list for that spot, next we append
        /// the the key value pair
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(Object key, Object value)
        {
            int idx = Hash(key);

            if (Bucket[idx] == null)
            {
                Bucket[idx] = new LList();
            }
            if(Get(key) == null)
            {
                Bucket[idx].Append(key, value);
            }
        }
        /// <summary>
        /// A way to get a specific node value from the specific index. Using Find method from the linked list Implementation
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Object Get(Object key)
        {
            int idx = Hash(key);
            if (Bucket[idx] == null)
            {
                return null;
            }

            Object findValue = Bucket[idx].Find(key);
            return findValue;
            
        }
        /// <summary>
        /// Boolean check to see if the value and key we ask for is actually there.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>

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
