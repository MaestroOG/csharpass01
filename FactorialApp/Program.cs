using System;
using FactorialLibrary;

namespace FactorialApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            long factorial = FactorialCalculator.CalculateFactorial(num);
            Console.WriteLine($"Factorial of {num} is {factorial}");
        }
    }
}
