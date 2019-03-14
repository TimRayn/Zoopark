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
        void LogMessege(string messege);

        void LogError();
    }
}
