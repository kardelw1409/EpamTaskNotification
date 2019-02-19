using System;
using System.Timers;

namespace Notification
{
    interface IDisplay
    {
        void Display(object obj, ElapsedEventArgs timeEvent);
    }
}
