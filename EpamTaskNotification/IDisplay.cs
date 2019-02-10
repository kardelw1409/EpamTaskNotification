using System;

namespace Notification
{
    interface IDisplay
    {
        void Display(Object obj, TimeEventArgs timeEvent);
    }
}
