using System;

namespace PrimeNumber
{
    class UC3_PrimeNumber
    {
        static void Main(string[] args)
        {
            int ReadNumber;
            int flag = 0;
            Console.Write("Enter the Number to check Whether Prime Or Not: ");
            ReadNumber = int.Parse(Console.ReadLine());
            int Quoetiont = ReadNumber / 2;
            for (int i = 2; i <= Quoetiont; i++)
            {
                if (ReadNumber % i == 0)
                {
                    Console.WriteLine("Number is Not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime");
        }  
    }
}
