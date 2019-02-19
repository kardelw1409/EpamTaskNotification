using System;
using System.Timers;

namespace EpamTaskNotification
{
    class TimeNotifier
    {
        public Timer Timers { get; set; }

        public TimeNotifier(int second)
        {
            Timers = new Timer(second * 1000);
        }

        public void Update()
        {
            Console.WriteLine("Press key to stop...");
            using (Timers)
            {
                while (!Console.KeyAvailable)
                {
                    Timers.AutoReset = true;
                    Timers.Enabled = true;
                }
                Timers.Stop();
            }
        }

    }
}
