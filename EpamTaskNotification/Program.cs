using EpamTaskNotification;
using EpamTaskNotification.NewCollection;
using System;
using System.Collections.Generic;

namespace Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Notifier notifier = new Notifier();
            var col = new MyCollection<IDisplay>
            {
                new ConsoleDisplay(),
                new FileDisplay()
            };
            foreach (IDisplay disp in col)
            {
                notifier.TimerEvent += disp.Display;
            }
            
            notifier.Update(5);*/

            TimeNotifier time = new TimeNotifier(5);
            var col = new MyCollection<IDisplay>();
            
            col.Add(new ConsoleDisplay());
            col.Add(new FileDisplay());
            
            foreach (IDisplay disp in col)
            {
                time.Timers.Elapsed += disp.Display;
            }
            time.Update();

            Console.ReadLine();
        }
    }
}
