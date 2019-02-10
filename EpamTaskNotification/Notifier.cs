using System;
using System.Timers;

namespace Notification
{
    class Notifier
    {
        public event EventHandler<TimeEventArgs> TimerEvent;
        //Timer timer;

        public void Update(int second)
        {
            Console.WriteLine("Press any key to stop...");
            TimeEventArgs eventArgs = new TimeEventArgs();
            eventArgs.Time = DateTime.Now;
            TimerEvent(this, eventArgs);
            DateTime updateTime = DateTime.Now.AddSeconds(second);
            while (!Console.KeyAvailable)
            {
                if (DateTime.Now.Hour == updateTime.Hour && DateTime.Now.Minute == updateTime.Minute && 
                    DateTime.Now.Second == updateTime.Second)
                {
                    eventArgs.Time = DateTime.Now;
                    TimerEvent(this, eventArgs);
                    updateTime = DateTime.Now.AddSeconds(second);
                }
            }

        }


    }
}
