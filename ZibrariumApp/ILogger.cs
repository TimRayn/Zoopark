using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
     public interface ILogger
    {
        void LogMessege(string messege);

        void LogError();
    }
}
