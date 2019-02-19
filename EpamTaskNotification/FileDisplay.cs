using System;
using System.IO;
using System.Timers;

namespace Notification
{
    class FileDisplay : IDisplay
    {

        public void Display(object obj, ElapsedEventArgs eventArgs)
        {
            string path = Directory.GetCurrentDirectory() + @"\log.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(eventArgs.SignalTime.ToLongTimeString());
            }
        }
        
    }
}
