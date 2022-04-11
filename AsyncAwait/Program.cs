using System;

namespace AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var s = new Scooter();

            while (true)
            {
                if (!s.IsOnTrip)
                {
                    s.StartTrip();
                    s.StartBatteryLoop();
                }

                if (s.BatteryLevel < 10)
                {
                    Console.WriteLine("Battery less than 10, stopping.");
                    s.StopTrip();
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
