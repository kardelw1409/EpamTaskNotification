using System;

namespace Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            IDisplay console = new ConsoleDisplay(notifier);
            IDisplay fileDisplay = new FileDisplay(notifier);
            notifier.Update(5);
            Console.ReadLine();
        }
    }
}
