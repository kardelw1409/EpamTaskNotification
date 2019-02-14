using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    class ConsoleDisplay  : IDisplay
    {
        public void Display(object obj, TimeEventArgs eventArgs)
        {
            Console.WriteLine(eventArgs.Time.ToLongTimeString());
        }
    }
}
