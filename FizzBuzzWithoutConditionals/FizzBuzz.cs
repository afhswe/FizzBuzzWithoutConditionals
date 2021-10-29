using System.Collections.Generic;

namespace FizzBuzzWithoutConditionals
{
    public class FizzBuzz
    {
        private int _number;

        public string CallNumber(int number)
        {
            _number = number;

            string currentResult = GetDivisibleResult(3, "Fizz");
            currentResult += GetDivisibleResult(5, "Buzz");
            currentResult = GetCombinedResult(currentResult);

            return CheckSpecialCaseZero(currentResult);
        }

        private string CheckSpecialCaseZero(string currentResult)
        {
            var finalResultMap = new Dictionary<string, string>()
            {
                {"Fizz", "Fizz"},
                {"Buzz", "Buzz"},
                {"FizzBuzz", "FizzBuzz"},
                {"0", "FizzBuzz"}
            };
            finalResultMap.TryAdd(_number.ToString(), _number.ToString());

            var finalResult = finalResultMap[currentResult];
            return finalResult;
        }

        private string GetCombinedResult(string currentResult)
        {
            var wordsOrNumber = new Dictionary<bool, string>();
            wordsOrNumber.Add(false, currentResult);
            wordsOrNumber.Add(true, _number.ToString());
            var result = wordsOrNumber[currentResult == ""];
            return result;
        }

        private string GetDivisibleResult(int divisibleBy, string word)
        {
            var resultMap = new Dictionary<int, string>()
            {
                {1, _number.ToString()},
                {2, _number.ToString()},
                {3, _number.ToString()},
                {4, _number.ToString()}
            };
            var foundWord = resultMap.TryGetValue(_number % divisibleBy, out _);

            var matchMap = new Dictionary<bool, string>()
            {
                {true, word},
                {false, ""}
            };

            return matchMap[!foundWord];
        }
    }
}