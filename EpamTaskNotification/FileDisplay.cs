using System;
using System.IO;

namespace Notification
{
    class FileDisplay : IDisplay
    {

        public void Display(Object obj, TimeEventArgs eventArgs)
        {
            string path = Directory.GetCurrentDirectory() + @"\log.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(eventArgs.Time.ToLongTimeString());
            }
        }

    }
}
