using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    public class DataReader : IDataReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
