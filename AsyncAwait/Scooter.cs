using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Scooter
    {
        public int BatteryLevel { get; set; }

        public int EngineTemp { get; set; }

        public bool IsOnTrip { get; set; }

        public Scooter()
        {
            BatteryLevel = 15;
            EngineTemp = 15;
        }

        public async void StartBatteryLoop()
        {
            while (true)
            {
                Console.WriteLine("BatteryLevel=" + BatteryLevel.ToString());
                if (IsOnTrip)
                {
                    BatteryLevel -= 1;
                    EngineTemp += 1;
                }
                if (BatteryLevel < 5)
                {
                    Console.WriteLine("BatteryLevel less than 5, stopping.");
                    return;
                }
                await Task.Delay(1000);
            }
        }

        public async void StartEngineLoop()
        {
            while (true)
            {
                Console.WriteLine("EngineTemp=" + EngineTemp.ToString());
                if (IsOnTrip)
                {
                    EngineTemp += 1;
                }
                if (EngineTemp > 60)
                {
                    Console.WriteLine("EngineTemp greater than 60, stopping.");
                    return;
                }
                await Task.Delay(1000);
            }
        }

        public void StartTrip()
        {
            IsOnTrip = true;
        }
        public void StopTrip()
        {
            IsOnTrip = false;
        }
    }
}
