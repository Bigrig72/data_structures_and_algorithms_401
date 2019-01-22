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
        public void ValueCanNotBeFound1()
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
        public void ValueCanNotBeFound2()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            list.Insert(9);
            list.Insert(6);

            //Act 

            bool isFound = list.Includes(4);

            //Assert
            Assert.False(isFound);

        }
        [Fact]
        public void ValueCanNotBeFound3()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            list.Insert(9);
            list.Insert(10);

            //Act 

            bool isFound = list.Includes(19);

            //Assert
            Assert.False(isFound);

        }
        [Fact]
        public void CanInstantiateNewList1()
        {
            //Arrange
            LList list = new LList();

            //Act 



            //Assert
            Assert.Null(list.Head);

        }

        [Fact]
        public void ValueCanBeInsertedBefore1()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            list.Insert(9);
            list.Insert(6);
            list.InsertBefore(9, 25);

            //Act 

         


            //Assert
            Assert.True(list.Includes(25));

        }
        [Fact]
        public void ValueCanBeInsertedBefore2()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            list.Insert(9);
            list.Insert(6);
            list.InsertBefore(6, 30);

            //Act 




            //Assert
            Assert.True(list.Includes(30));

        }
        [Fact]
        public void ValueCanBeInsertedBefore3()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            list.Insert(9);
            list.Insert(6);
            list.InsertBefore(9, 40);

            //Act 




            //Assert
            Assert.True(list.Includes(40));

        }



        [Fact]
        public void Append1()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            //list.Insert(9);
            //list.Insert(6);
            list.Append(10);

            //Act 

            bool isFound = list.Includes(10);

            //Assert
            Assert.True(isFound);

        }
        [Fact]
        public void Append2()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            //list.Insert(9);
            //list.Insert(6);
            list.Append(14);

            //Act 

            bool isFound = list.Includes(14);

            //Assert
            Assert.True(isFound);

        }
        [Fact]
        public void Append3()
        {
            //Arrange
            LList list = new LList();
            list.Insert(5);
            //list.Insert(9);
            //list.Insert(6);
            list.Append(20);

            //Act 

            bool isFound = list.Includes(20);

            //Assert
            Assert.True(isFound);

        }
    }
}
