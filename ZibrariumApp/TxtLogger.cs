using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    //Todo: Дофиксить нормально чтоб работало
    class TxtLogger : ILogger
    {
        private static string pathErr = @"C:\Users\Korabel\Desktop\logErrors.txt";
        private static string pathMess = @"C:\Users\Korabel\Desktop\logMessages.txt";
        FileInfo logErr = new FileInfo(pathErr);
        FileInfo logMess = new FileInfo(pathMess);

        public void LogError(string errorMessage, Exception e)
        {
            if (!logErr.Exists)
            {
                using (FileStream fstream = new FileStream(@"C:\Users\Korabel\Desktop\logErrors.txt", FileMode.Append))
                {
                    byte[] array = Encoding.Default.GetBytes(errorMessage);
                    fstream.Write(array, 0, array.Length);
                }
            }
        }

        public void LogError(string errorMessage)
        {
            if (!logErr.Exists)
            {
                using (FileStream fstream = new FileStream(@"C:\Users\Korabel\Desktop\logErrors.txt", FileMode.Append))
                {
                    byte[] array = Encoding.Default.GetBytes(errorMessage);
                    fstream.Write(array, 0, array.Length);
                }
            }
        }

        public void LogMessage(string message)
        {
            if (!logMess.Exists)
            {
                using (FileStream fstream = new FileStream(@"C:\Users\Korabel\Desktop\logMessages.txt", FileMode.Append))
                {
                    byte[] array = Encoding.Default.GetBytes(message);
                    fstream.Write(array, 0, array.Length);
                }
            }
        }

        public void LogMessage(string message, ConsoleColor color)
        {
            if (!logMess.Exists)
            {
                using (FileStream fstream = new FileStream(@"C:\Users\Korabel\Desktop\logMessages.txt", FileMode.Append))
                {
                    byte[] array = Encoding.Default.GetBytes(message);
                    fstream.Write(array, 0, array.Length);
                }
            }
        }
    }
}
