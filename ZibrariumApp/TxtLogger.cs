using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class TxtLogger : ILogger
    {
        public void LogError(string errorMessage, Exception e)
        {
            throw new NotImplementedException();
        }

        public void LogError(string errorMessage)
        {
            throw new NotImplementedException();
        }

        public void LogMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void LogMessage(string message, ConsoleColor color)
        {
            throw new NotImplementedException();
        }
    }
}
