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
        public void NumberCallsNumber()
        {
            FizzBuzz(1).Should().Be("1");
            FizzBuzz(2).Should().Be("2");
        }

        [Fact]
        public void DivisibleByThreeCallsFizz()
        {
            FizzBuzz(3).Should().Be("Fizz");
        }

        [Fact]
        public void DivisibleByFiveCallsBuzz()
        {
            FizzBuzz(5).Should().Be("Buzz");
        }

        [Fact]
        public void DivisibleByThreeAndFiveCallsFizzBuzz()
        {
            FizzBuzz(15).Should().Be("FizzBuzz");
        }

        [Theory]
        [InlineData(0, "FizzBuzz")]
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

        public void CallsCorrectWordForNumber(int number, string expectedWord)
        {
            FizzBuzz(number).Should().Be(expectedWord);
        }

        private string FizzBuzz(int number)
        {
            return new FizzBuzz().CallNumber(number);
        }
    }
}
