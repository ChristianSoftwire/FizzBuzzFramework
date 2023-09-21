using System;

namespace FizzbuzzFramework
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzz();
        }

        private static string GetResultOfNumber(int number)
        {
            var result = "";
            if (CheckNumberIsDivisibleBy(number, denominator: 11))
            {
                result = "Bong";
                    
            }
            else if (CheckNumberIsDivisibleBy(number, 3) && CheckNumberIsDivisibleBy(number, 5))
            {
                result = "FizzBuzz";
            }
            else if (CheckNumberIsDivisibleBy(number, 3))
            {
                result = "Fizz";
            }
            else if (CheckNumberIsDivisibleBy(number, 5))
            {
                result = "Buzz";
            }
            else if (CheckNumberIsDivisibleBy(number, 7))
            {
                result = result != "" ? result + "Bang" : "Bang";
            }
            else
            {
                result = number.ToString();
            }

            return result;
        }

        private static void FizzBuzz()
        {
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(GetResultOfNumber(i));
            }
        }

        private static bool CheckNumberIsDivisibleBy(int numerator, int denominator)
        {
            if (numerator % denominator == 0)
            {
                return true;
            }

            return false;
        }
    }
}