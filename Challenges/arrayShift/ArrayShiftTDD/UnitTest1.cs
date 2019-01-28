using System;
using Xunit;
using arrayShift;

namespace ArrayShiftTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            int[] shiftedArray = new int[] { 3, 4, 5, 6 };
            int num = 9;

            //act

            int[] newArray = Program.ArrayShift(shiftedArray, num);
            string outputArr = (string.Join(",", newArray));
            //assert
            Assert.Equal("3,4,9,5,6", outputArr);
        }
        [Fact]
        public void Test2()
        {
            //arrange
            int[] shiftedArray = new int[] { 2, 5, 9, 6 };
            int num = 12;

            //act

            int[] newArray = Program.ArrayShift(shiftedArray, num);
            string outputArr = (string.Join(",", newArray));
            //assert
            Assert.Equal("2,5,12,9,6", outputArr);
        }
    }
}
