using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }



        public void LogError(string errorMessage, Exception e)
        {
            Console.WriteLine(errorMessage);
            Console.WriteLine($"Ошибка:\n{e}");
        }

        public void LogError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }

    }
}
