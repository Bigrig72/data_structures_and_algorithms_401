using LinkedListChallenge01;
using Xunit;

namespace LinkedListTDD
{
    public class UnitTest1
    {
        [Fact]
        public void PlaceFromEndWork()
        {
            //Arrange
            int value = 3;

            //act

            int result = Program.PlaceFromEnd(value);
            //assert

            Assert.Equal(4, result);

        }
        [Fact]
        public void PlaceFromEndWork2()
        {
            //Arrange
            int value = 4;

            //act

            int result = Program.PlaceFromEnd(value);
            //assert

            Assert.Equal(5, result);

        }
        [Fact]
        public void PlaceFromEndWork3()
        {
            //Arrange
            int value = 5;

            //act

            int result = Program.PlaceFromEnd(value);
            //assert

            Assert.Equal(6, result);

        }
    }
}
