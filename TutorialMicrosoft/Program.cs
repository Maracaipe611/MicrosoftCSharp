using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 0, 1 };

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            int prox;


            /* For */
            for(int fibo = 1; fibo <= 20; fibo++)
            {
                prox = previous + previous2;
                Console.WriteLine($"{fibo} = {previous + previous2}");
                previous = previous2;
                previous2 = prox;
            }

            /* Foreach */
            var fibNumbers = new List<int> { 0, 1};
            int count = 0, primeiro = fibNumbers[0], segundo = fibNumbers[1];
            
            while (fibNumbers.Count <= 20);{
                primeiro = fibNumbers[fibNumbers.Count - 2];
                segundo = fibNumbers[fibNumbers.Count - 1];
                fibNumbers.Add(primeiro + segundo);
                }
                    foreach (int item in fibNumbers)
                Console.WriteLine($"O {count}º é igual á {segundo}"); 
            
            
        }
    }
}
