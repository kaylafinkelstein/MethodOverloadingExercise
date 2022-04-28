using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 50;
            var b = 32;

            var answer = Add(a, b);

            var x = 365.1m;
            var y = 32.5m;

            var decimalSolution = Add(x, y);

            var finalSolution = Add(500, 25, true);

            Console.WriteLine($"Adding two integers: {answer}. Adding two decimals: {decimalSolution}.");
            Console.WriteLine($"{finalSolution}");
        }
        
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        
        public static string Add(int num1, int num2, bool IsTrue)
        {
            var sum = num1 + num2;

            if (IsTrue == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else if (IsTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (IsTrue == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
