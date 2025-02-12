using System;

namespace FactorialLibrary
{
    public class FactorialCalculator
    {
        public static long CalculateFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number must be non-negative.");

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
