using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public static class IntExtensions
    {
        public static bool IsDivisibleBy(this int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
