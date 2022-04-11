using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Scooter
    {
        public int BatteryLevel { get; set; }

        public bool IsOnTrip { get; set; }

        public Scooter()
        {
            BatteryLevel = 15;
        }

        public async void StartBatteryLoop()
        {
            while (true)
            {
                Console.WriteLine("Battery level " + BatteryLevel.ToString());
                if (IsOnTrip)
                {
                    BatteryLevel -= 1;
                }
                if (BatteryLevel < 5)
                {
                    Console.WriteLine("Battery less than 5, stopping.");
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
