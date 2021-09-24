using System;

namespace FibonacciSeries
{
    class UC1_FibonacciSeries
    {
        static void Main(string[] args)
        {
            int Number1 = 0;
            int Number2 = 1;
            int Number3;
            int Number;

            Console.Write("Enter the Number to Fibonacci Series: ");
            Number = int.Parse(Console.ReadLine());
            Console.WriteLine(Number1 + " " + Number2 + " ");

            for(int i = 2; i<Number; i++)
            {
                Number3 = Number1 + Number2;
                Console.WriteLine(Number3 + " ");
                Number1 = Number2;
                Number2 = Number3;
            }
        }
    }
}
