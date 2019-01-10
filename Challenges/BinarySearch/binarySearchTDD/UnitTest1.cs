using System;
using Xunit;
using Code_challenge_03;

namespace binarySearchTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestCheckingThatKeyDoesNotExist()
        {
            //arrange
            int[] binarySearch = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int key = 15;

            //act
           int storedValue = Program.BinarySearch(binarySearch, key);

            //assert

            Assert.Equal(-1, storedValue);
        }
        [Fact]
        public void TestCheckingThatKeyDoesExist()
        {
            //arrange
            int[] binarySearch = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int key = 7;

            //act
            int storedValue = Program.BinarySearch(binarySearch, key);

            //assert

            Assert.Equal(6, storedValue);
        }
        [Fact]
        public void TestCheckingThatKeyDoesExist2()
        {
            //arrange
            int[] binarySearch = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int key = 3;

            //act
            int storedValue = Program.BinarySearch(binarySearch, key);

            //assert

            Assert.Equal(2, storedValue);
        }
    }
}
