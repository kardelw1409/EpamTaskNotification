using System;
using System.Timers;

namespace Notification
{
    class ConsoleDisplay  : IDisplay
    {
        public void Display(object obj, ElapsedEventArgs eventArgs)
        {
            Console.WriteLine(eventArgs.SignalTime.ToLongTimeString());
        }
    }
}
