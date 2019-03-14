using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    public class Penguin : Animal
    {
        private ILogger Logger { get; set; }
        public Penguin(string name)
           : base(name)
        {
            // добавить им чето свое
        }

        public override void Pokormit()
        {
            Logger.LogMessege("You pokormile penguina. On pokazal vam middle palec.");
        }

    }

}
