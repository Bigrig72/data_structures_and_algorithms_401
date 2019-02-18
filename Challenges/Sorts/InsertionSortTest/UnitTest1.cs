using InsertionSort;
using Xunit;


namespace InsertionSortTest
{
    //TEST 1X A randomly generated unsorted array returns the array sorted
    //TEST 2X A sorted array returns the same sorted array
    //TEST 3X A backwards-sorted array returns the array sorted
    //TEST 4X An empty array returns the same empty array
    //TEST 5X An array of one element returns the same single-element array
    public class UnitTest1
    {
        [Fact]
        public void TEST1SortArray()
        {
            int[] array = { 9, 5, 7, 2, 1, 3, 19 };
            Sort anyArray = new Sort(array);
            anyArray.InsertionSort();

            int[] array2 = { 1, 2, 3, 5, 7, 9, 19 };

            Assert.Equal(array2, array);
        }
       
        
        [Fact]
        public void TEST2SortArrayOfSameArray()
        {
            int[] array = { 1, 2, 3, 5, 7, 9, 19 };
            Sort anyArray = new Sort(array);
            anyArray.InsertionSort();

            int[] array2 = { 1, 2, 3, 5, 7, 9, 19 };

            Assert.Equal(array2, array);

        }

        [Fact]
        public void TEST3SortArrayBackwards()
        {
            int[] array = { 7, 6, 5, 4, 3, 2, 1 };
            Sort anyArray = new Sort(array);
            anyArray.InsertionSort();

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7 };

            Assert.Equal(array2, array);

        }

        [Fact]
        public void TEST4SortArrayEMPTY()
        {
            int[] array = {};
            Sort anyArray = new Sort(array);
            anyArray.InsertionSort();

            int[] array2 = {};

            Assert.Equal(array2, array);

        }

        [Fact]
        public void TEST5SortArrayOneElement()
        {
            int[] array = {5};
            Sort anyArray = new Sort(array);
            anyArray.InsertionSort();

            int[] array2 = {5};

            Assert.Equal(array2, array);

        }
    }
}

