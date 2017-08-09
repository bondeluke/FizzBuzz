using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        private Dictionary<int, string> _fizzBuzzDict;

        public FizzBuzzGenerator(Dictionary<int, string> fizzBuzzDict)
        {
            _fizzBuzzDict = fizzBuzzDict;
        }

        public string[] GenerateList(int upTo)
        {
            var listOfString = new List<string>();

            for (int number = 1; number <= upTo; number++)
            {
                listOfString.Add(GetStringFromNumber(number));
            }

            return listOfString.ToArray();
        }

        private string GetStringFromNumber(int number)
        {
            var output = string.Empty;

            foreach (var entry in _fizzBuzzDict)
            {
                if (number.IsDivisibleBy(entry.Key))
                {
                    output += entry.Value;
                }
            }

            return output.Length > 0
                ? output
                : number.ToString();
        }
    }
}
