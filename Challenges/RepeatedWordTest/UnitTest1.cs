using System;
using Xunit;
using RepeatedWord;

namespace RepeatedWordTest
{
    public class UnitTest1
    {/// <summary>
    /// Checki9njg to see if a is the first most common word
    /// </summary>
        [Fact]
        public void Test1()
        {
            string input = "Once upon a time, there was a brave who...";

            Assert.Equal("a", Program.RepeatedWords(input));

        }
        /// <summary>
        /// checking to see if b is first the most common word
        /// </summary>
        [Fact]
        public void Test2()
        {
            string input = "Once upon b time, there was b brave who...";

            Assert.Equal("b", Program.RepeatedWords(input));

        }
    }
}
