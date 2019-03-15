using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    public class Penguin : Animal
    {
        
        public Penguin(string name)
           : base(name)
        {
            // добавить им чето свое
        }

        public override void Pokormit()
        {
            DoOnMessage("You pokormile penguina. On pokazal vam middle palec.");
        }

    }

}
