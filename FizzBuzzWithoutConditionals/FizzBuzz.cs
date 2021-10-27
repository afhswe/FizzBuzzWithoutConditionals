using System.Collections.Generic;

namespace FizzBuzzWithoutConditionals
{
    public class FizzBuzz
    {
        private Dictionary<int, string> _resultMap;

        public string CallNumber(int number)
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
            var foundWord = _resultMap.TryGetValue(number % divisibleBy, out dummyResultString);

            var matchMap = new Dictionary<bool, string>()
            {
                {true, word},
                {false, ""}
            };

            return matchMap[!foundWord];
        }

        private void initResultMap(int number)
        {
            _resultMap = new Dictionary<int, string>()
            {
                {1, number.ToString()},
                {2, number.ToString()},
                {3, number.ToString()},
                {4, number.ToString()}
            };
            _resultMap.TryAdd(number, number.ToString());
        }
    }
}