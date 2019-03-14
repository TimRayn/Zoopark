using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    public class ConsoleLogger : ILogger, IDataReader
    {
        public void LogMessege(string messege)
        {
            Console.WriteLine(messege);
        }

        public void LogError()
        {
            throw new NotImplementedException();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
