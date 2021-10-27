using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;

namespace FizzBuzzWithoutConditionals
{
    public class FizzBuzzTest
    {
        // TODO-List
        // 1 => "1" => DONE
        // 2 => "2"
        // 3 => "Fizz"
        // 5 => "Buzz"
        // 15 => "CallNumber"

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

        private string FizzBuzz(int number)
        {
            return new FizzBuzz().CallNumber(number);
        }
    }
}
