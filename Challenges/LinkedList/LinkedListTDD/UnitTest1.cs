using System;
using Xunit;
using LinkedList.classes;

namespace LinkedListTDD
{
    public class UnitTest1
    {
        [Fact]
        public void ValueCanBeFound()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            list.Insert(8);
            list.Insert(6);

            //Act 

            bool isFound = list.Includes(8);

            //Assert
            Assert.True(isFound);

        }
        [Fact]
        public void ValueCanNotBeFound()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            list.Insert(9);
            list.Insert(6);

            //Act 

            bool isFound = list.Includes(8);

            //Assert
            Assert.False(isFound);

        }
        [Fact]
        public void CanInstantiateNewList()
        {
            //Arrange
            LList list = new LList();
           
            //Act 

           

            //Assert
            Assert.Null(list.Head);

        }
    }
}
