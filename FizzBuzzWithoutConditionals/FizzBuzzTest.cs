using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;

namespace FizzBuzzWithoutConditionals
{
    public class FizzBuzzTest
    {
        [Fact]
        public void OneShowsOne()
        {
            string result = FizzBuzz(1);
            result.Should().Be("1");
        }

        [Fact]
        public void TwoShowsTwo()
        {
            string result = FizzBuzz(2);
            result.Should().Be("2");
        }

        [Fact]
        public void ThreeShowsFizz()
        {
            string result = FizzBuzz(3);
            result.Should().Be("Fizz");
        }

        [Fact]
        public void FiveShowsBuzz()
        {
            string result = FizzBuzz(5);
            result.Should().Be("Buzz");
        }

        [Fact]
        public void FifteenShowsFizzBuzz()
        {
            string result = FizzBuzz(15);
            result.Should().Be("FizzBuzz");
        }

        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(16, "16")]
        [InlineData(17, "17")]
        [InlineData(27, "Fizz")]
        [InlineData(28, "28")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(31, "31")]

        public void ShouldCallWordForNumber(int number, string expectedWord)
        {
            string result = FizzBuzz(number);
            result.Should().Be(expectedWord);
        }

        private string FizzBuzz(int number)
        {
            return new FizzBuzz().CallNumber(number);
        }
    }
}
