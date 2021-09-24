using System;

namespace ReverseNumber
{
    class UC4_ReverseNumber
    {
        static void Main(string[] args)
        {
            int Number;
            int Reverse = 0;
            int Reminder = 0;
            Console.Write("Enter the Number To Reverse: ");
            Number = int.Parse(Console.ReadLine());
            Reverse = 0;
            while(Number>0)
            {
                Reminder = Number % 10;
                Reverse = (Reverse * 10) + Reminder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse Number is {0} ", Reverse);
        }
    }
}
