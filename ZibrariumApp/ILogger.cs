using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    //Todo: створити ще одну реалізацію - TxtLogger, який буде логувати в файл log.txt
     public interface ILogger
     {
         void LogMessage(string message, ConsoleColor color);
         void LogMessage(string message);

         void LogError(string errorMessage, Exception e);
         void LogError(string errorMessage);
     }
}
