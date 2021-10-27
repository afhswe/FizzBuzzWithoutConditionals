using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;

namespace FizzBuzzWithoutConditionals
{
    public class FizzBuzzTest
    {
        private Dictionary<int, string> _resultMap;
        // TODO-List
        // 1 => "1" => DONE
        // 2 => "2"
        // 3 => "Fizz"
        // 5 => "Buzz"
        // 15 => "FizzBuzz"

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
            initResultMap(number);
            string currentResult = GetDivisibleResult(number, 3, "Fizz");
            currentResult += GetDivisibleResult(number, 5, "Buzz");
            return GetFizzBuzzResult(number, currentResult);
        }

        private static string GetFizzBuzzResult(int number, string currentResult)
        {
            var wordsOrNumber = new Dictionary<bool, string>();
            wordsOrNumber.Add(false, currentResult);
            wordsOrNumber.Add(true, number.ToString());
            return wordsOrNumber[currentResult == ""];
        }

        private string GetDivisibleResult(int number, int divisibleBy, string word)
        {
            var dummyResultString = "";
            var foundFive = _resultMap.TryGetValue(number % divisibleBy, out dummyResultString);

            var matchMap = new Dictionary<bool, string>()
            {
                {true, word},
                {false, ""}
            };

            return matchMap[!foundFive];
        }

        private void initResultMap(int number)
        {
            _resultMap = new Dictionary<int, string>()
            {
                {1, number.ToString()},
                {2, number.ToString()},
            };
            _resultMap.TryAdd(number, number.ToString());
        }
    }
}
