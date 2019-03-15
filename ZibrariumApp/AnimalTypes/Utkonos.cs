using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class Utkonos : Animal
    {
      
        public Utkonos(string name)
            : base(name)
        {

        }
        public override void Pokormit()
        {
            DoOnMessage("You pokormile utkonosa. Zachem?");
        }

    }
}
