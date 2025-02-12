using System;
using System.Threading;

namespace ThreadSyncApp
{
    class Program
    {
        private static readonly object lockObject = new object();
        private static int number = 1; // Shared counter

        static void Main()
        {
            Thread evenThread = new Thread(PrintEvenNumbers);
            Thread oddThread = new Thread(PrintOddNumbers);

            evenThread.Start();
            oddThread.Start();

            evenThread.Join(); // Wait for evenThread to finish
            oddThread.Join(); // Wait for oddThread to finish

            Console.WriteLine("Both threads have completed execution.");
        }

        static void PrintEvenNumbers()
        {
            while (number <= 20)
            {
                lock (lockObject)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Even: {number}");
                        number++;
                    }
                }
                Thread.Sleep(100); // Simulate work
            }
        }

        static void PrintOddNumbers()
        {
            while (number <= 20)
            {
                lock (lockObject)
                {
                    if (number % 2 != 0)
                    {
                        Console.WriteLine($"Odd: {number}");
                        number++;
                    }
                }
                Thread.Sleep(100); // Simulate work
            }
        }
    }
}
