using System;
using Xunit;
using HashTable.Classes;
using LinkedList.classes;

namespace HashTableTesting
{

//TEST 1X Adding a key/value to your hashtable results in the value being in the data structure
//TEST 2X Retrieving based on a key returns the value stored
//TEST 3X Successfully returns null for a key that does not exist in the hashtable
//TEST 4X Successfully handle a collision within the hashtable
//TEST 5X Successfully retrieve a value from a bucket within the hashtable that has a collision
//TEST 6X Successfully hash a key to an in-range value
    public class UnitTest1
    {
        /// <summary>
        /// Checking to see if we can use the hash function effectively and give a certain
        /// index for the key and value pair.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="indx"></param>
        [Theory]
        [InlineData("regan", 1004)]
        [InlineData("is", 413)]
        [InlineData("super", 608)]
        [InlineData("cool", 284)]
        
        public void AddingKeyAndValueToHashTable(Object key, int indx)
        {
            HashTableSetup table = new HashTableSetup(1024);
            
            Assert.Equal(indx, table.Hash(key));
           
        }
        /// <summary>
        /// Checking that we can go and find the key after successfully adding the key value pair
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        [Theory]
        [InlineData("regan", 1004)]
        [InlineData("is", 413)]
        [InlineData("super", 608)]
        [InlineData("cool", 284)]
        public void Add(Object key, int value)
        {
            HashTableSetup table = new HashTableSetup(1024);
            table.Add(key, value);

            Object nodeValue = table.Bucket[value].Find(key);

            Assert.Equal(value, nodeValue);
      
        }
        /// <summary>
        /// Checking to see if the key im asking for is not there, should return null.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        [Theory]
        [InlineData("regan", 1004)]
        [InlineData("is", 413)]
        [InlineData("super", 608)]
        [InlineData("cool", 284)]
        public void CheckNullForNoValue(Object key, int value)
        {
            HashTableSetup table = new HashTableSetup(1024);
            table.Add(key, value);

            Object nodeValue = table.Bucket[value].Find("dan");

            Assert.Null(nodeValue);

        }/// <summary>
        /// Checking to see if the value and key is contained at that specific index.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        [Theory]
        [InlineData("regan", 1004)]
        [InlineData("is", 413)]
        [InlineData("super", 608)]
        [InlineData("cool", 284)]
        public void CheckContainsValue(Object key, int value)
        {
            HashTableSetup table = new HashTableSetup(1024);
            table.Add(key, value);

            Object nodeValue = table.Bucket[value].Find(key);

            Assert.True(table.Contains(key,value));

        }
        /// <summary>
        /// Handle a collision properly withing an index of the table
        /// </summary>
        [Fact]        
        public void HandleCollision()
        { 
            HashTableSetup table = new HashTableSetup(1024);
            table.Add("below", 72);
            table.Add("elbow", 72);

            Assert.True(table.Contains("below", 72));
            Assert.True(table.Contains("elbow", 72));
        }
        /// <summary>
        /// Shows that we can retrieve the value at the specific index with a collision
        /// </summary>
        [Fact]       
        public void RetrievCollisionValues()
        {
            HashTableSetup table = new HashTableSetup(1024);
            table.Add("below", 72);
            table.Add("elbow", 72);

            Object FindValue1 = table.Bucket[72].Find("below");
            Object FindValue2 = table.Bucket[72].Find("elbow");

            Assert.True(table.Contains("below", 72));
            Assert.True(table.Contains("elbow", 72));


        }
    }
}
