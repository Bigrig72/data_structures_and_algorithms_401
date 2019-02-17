using System;
using Xunit;
using HashTable.Classes;

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
       [Fact]
        public void Add()
        {
            HashTableSetup table = new HashTableSetup(1024);
           var x= table.Hash(1004);
           table.Add("regan", x);
            bool isfound = table.Get(x).Equals("regan");
            Assert.True(isfound);
        }
    }
}
