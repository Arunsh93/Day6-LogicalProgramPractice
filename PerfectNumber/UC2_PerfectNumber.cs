using System;

namespace PerfectNumber
{
    class UC2_PerfectNumber
    {
        static void Main(string[] args)
        {
            int Number;
            Console.Write("Enter the Number to Check perfect number or not: ");
            Number = int.Parse(Console.ReadLine());

            int sum = 0;
            Console.WriteLine("the Positive Devisor");
            for(int i=1;i<Number;i++)
            {
                if(Number%i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.WriteLine("Sum of the Devisor is: {0}", +sum);
            if(sum == Number)
            {
                Console.WriteLine("The Number is Perfect");
            }
            else
            {
                Console.WriteLine("The Number is not Perfect");
            }
        }
    }
}
