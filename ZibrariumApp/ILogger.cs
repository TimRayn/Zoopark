using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
     public interface ILogger
     {
         void LogMessage(string message, ConsoleColor color);
         void LogMessage(string message);

         void LogError(string errorMessage, Exception e);
         void LogError(string errorMessage);
     }
}
