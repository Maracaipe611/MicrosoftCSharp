using System;
using System.Collections.Generic;

namespace TutorialMicrosoft
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 0, 1 };

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            int prox;


            for(int fibo = 1; fibo <= 20; fibo++)
            {
                prox = previous + previous2;
                Console.WriteLine($"{fibo} = {previous + previous2}");
                previous = previous2;
                previous2 = prox;
            }
        }
    }
}
