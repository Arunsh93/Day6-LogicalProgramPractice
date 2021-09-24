using System;

namespace StopWatch
{
    class UC7_StopWatch
    {
        static void Main(string[] args)
        {
            long startTimer;
            long stopTimer;
            Console.WriteLine("Press '1' to start time: ");
            startTimer = long.Parse(Console.ReadLine());
            Console.WriteLine("Start time is: " + startTimer);
            startTimer = startTimer * 1000;

            Console.WriteLine("Press '2' to stop time: ");
            stopTimer = long.Parse(Console.ReadLine());
            Console.WriteLine("Start time is: " + stopTimer);
            stopTimer = stopTimer * 1000;
            long elapsed = stopTimer - startTimer;
            Console.WriteLine("Total elapsed time in mileStones is: " + elapsed);
        }
    }
}
