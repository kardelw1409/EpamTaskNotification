using System;
using System.IO;

namespace Notification
{
    class FileDisplay : IDisplay
    {
        
        public FileDisplay(Notifier notifier)
        {
            notifier.TimerEvent += Display;
        }

        public void Display(Object obj, TimeEventArgs eventArgs)
        {
            string path = Directory.GetCurrentDirectory() + @"\log.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("{0}:{1}:{2}", eventArgs.Time.Hour, eventArgs.Time.Minute, eventArgs.Time.Second);
            }
        }

    }
}
