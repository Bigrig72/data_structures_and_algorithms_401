using System;
using Xunit;
using MultiBracketValidation.classes;
using MultiBracketValidation;

namespace BrackValidationTDD
{
    public class UnitTest1
    {/// <summary>
    /// Showing we can create a node that is type char
    /// </summary>
        [Fact]
        public void ShowTheNodeIsTypeChar()
        {
            Node word = new Node('v');
            Assert.Equal('v', word.Value);
        }
        /// <summary>
        /// Showing the property Next
        /// </summary>
        [Fact]     
        public void ShowTheNextProperty()
        {
            Node word = new Node('v');
            Node word2 = new Node('t');
            Stack stack = new Stack();
            stack.Push('v');
            stack.Push('t');

            Assert.Equal('v', stack.Top.Next.Value);
        }
        /// <summary>
        /// Showing the pushing to the stack will work
        /// </summary>
        [Fact]
        public void ShowThatPushingToTheStackWorks()
        {
            Stack stack = new Stack();
            Node word = new Node('v');
            Node word2 = new Node('t');
            stack.Push('v');
            stack.Push('t');
            Assert.Equal('t', stack.Top.Value);
        }
        /// <summary>
        /// Popping from the stack works
        /// </summary>
        [Fact]
        public void ShowThatPoppingFromTheStackWorks()
        {
            Stack stack = new Stack();
            Node word = new Node('v');
            Node word2 = new Node('t');
            stack.Push('v');
            stack.Push('t');
            stack.Pop();
            
            Assert.Equal('v', stack.Top.Value);
        }
        [Fact]
        public void ShowThatPoppingFromTheStackWorks2()
        {
            Stack stack = new Stack();
            Node word = new Node('v');
            Node word2 = new Node('t');
            stack.Push('v');
            stack.Push('t');
            stack.Push('a');
            stack.Pop();

            Assert.Equal('t', stack.Top.Value);
        }
        [Fact]
        public void ShowThatPoppingFromTheStackWorks3()
        {
            Stack stack = new Stack();
            Node word = new Node('v');
            Node word2 = new Node('t');
            stack.Push('v');
            stack.Push('t');
            stack.Push('j');
            stack.Push('h');
            stack.Pop();

            Assert.Equal('j', stack.Top.Value);
        }/// <summary>
        /// Next 3 tests show the main method that will check perfect bracket sequence
        /// </summary>
        [Fact]
        public void DemonstrateBracketValidationWorksIsTrue()
        {
            string input = "[bobiscool]";
            Stack stack = new Stack();
            char[] inputArray = input.ToCharArray();
            Assert.True(Program.MultiBracketValidation2(input));

        }        
        [Fact]
        public void DemonstrateBracketValidationIsFalse()
        {
            string input = "[bobiscool](";
            Stack stack = new Stack();
            char[] inputArray = input.ToCharArray();
            Assert.False(Program.MultiBracketValidation2(input));

        }
        [Fact]
        public void DemonstrateBracketValidationIsTrue2()
        {
            string input = "[bobiscool][]";
            Stack stack = new Stack();
            char[] inputArray = input.ToCharArray();
            Assert.True(Program.MultiBracketValidation2(input));

        }
    }
}
