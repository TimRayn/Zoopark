using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class TxtLogger : ILogger
    {
        private static string pathErr = @"C:\Users\maxfo\Desktop\logErrors.txt";
        private static string pathMess = @"C:\Users\maxfo\Desktop\logMessages.txt";
        FileInfo logErr = new FileInfo(pathErr);
        FileInfo logMess = new FileInfo(pathMess);
        ILogger Logger = new ConsoleLogger();

        public void LogError(string errorMessage, Exception e)
        {
            Logger.LogError(errorMessage, e);
            if (!logErr.Exists)
            {
                using (StreamWriter sw = new StreamWriter(pathErr, true, Encoding.Default))
                {
                    sw.WriteLine(errorMessage);
                    sw.WriteLine($"Ошибка:\n{e}");
                }
                //using (FileStream fstream = new FileStream(@"C:\Users\Korabel\Desktop\logErrors.txt", FileMode.Append))
                //{
                //    byte[] array = Encoding.Default.GetBytes(errorMessage);
                //    fstream.Write(array, 0, array.Length);
                //}
            }

        }

        public void LogError(string errorMessage)
        {
            Logger.LogError(errorMessage);
            if (!logErr.Exists)
            {
                using (StreamWriter sw = new StreamWriter(pathErr, true, Encoding.Default))
                {
                    sw.WriteLine(errorMessage);
                }
                //using (FileStream fstream = new FileStream(@"C:\Users\Korabel\Desktop\logErrors.txt", FileMode.Append))
                //{
                //    byte[] array = Encoding.Default.GetBytes(errorMessage);
                //    fstream.Write(array, 0, array.Length);
                //}
            }
        }

        public void LogMessage(string message)
        {
            Logger.LogMessage(message);
            if (!logMess.Exists)
            {
                using (StreamWriter sw = new StreamWriter(pathMess, true, Encoding.Default))
                {
                    sw.WriteLine(message);
                }
                //using (FileStream fstream = new FileStream(@"C:\Users\Korabel\Desktop\logMessages.txt", FileMode.Append))
                //{
                //    byte[] array = Encoding.Default.GetBytes(message);
                //    fstream.Write(array, 0, array.Length);
                //}
            }
        }

        public void LogMessage(string message, ConsoleColor color)
        {
            Logger.LogMessage(message, color);
            if (!logMess.Exists)
            {
                using (StreamWriter sw = new StreamWriter(pathMess, true, Encoding.Default))
                {
                    sw.WriteLine(message);
                }
                //using (FileStream fstream = new FileStream(@"C:\Users\Korabel\Desktop\logMessages.txt", FileMode.Append))
                //{
                //    byte[] array = Encoding.Default.GetBytes(message);
                //    fstream.Write(array, 0, array.Length);
                //}
            }
        }
    }
}
