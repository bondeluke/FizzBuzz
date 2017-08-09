using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new FizzBuzzGenerator(new Dictionary<int, string>()
            {
                {3, "Fizz" },
                {5, "Buzz" }
            });

            var upTo = 100;

            foreach (var item in generator.GenerateList(upTo))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}