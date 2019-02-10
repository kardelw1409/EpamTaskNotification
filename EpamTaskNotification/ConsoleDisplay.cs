using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    class ConsoleDisplay : IDisplay
    {
        public ConsoleDisplay(Notifier notifier)
        {
            notifier.TimerEvent += Display;
        }

        public void Display(Object obj, TimeEventArgs eventArgs)
        {
            Console.WriteLine("{0}:{1}:{2}",eventArgs.Time.Hour, eventArgs.Time.Minute, eventArgs.Time.Second);
        }
    }
}
