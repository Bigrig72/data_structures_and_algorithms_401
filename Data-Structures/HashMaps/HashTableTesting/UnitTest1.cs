using System;
using Xunit;
using HashTable.Classes;
using LinkedList.classes;

namespace HashTableTesting
{
    public class UnitTest1
    {
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
        [Theory]
        [InlineData("regan", 1004)]
        public void Add(Object key, int value)
        {
            HashTableSetup table = new HashTableSetup(1024);
            table.Add(key, value);

            Object nodeValue = table.Bucket[value].Find(key);

            Assert.Equal(value, nodeValue);
       
            //Assert.True(table.Contains("regan", 1004));

        }
    }
}
