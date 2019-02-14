using System;

namespace Notification
{
    interface IDisplay
    {
        void Display(object obj, TimeEventArgs timeEvent);
    }
}
