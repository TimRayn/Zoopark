using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class Ravlick : Animal
    {
      
        public Ravlick(string name) 
            : base(name)
        {

        }

        public override void Pokormit()
        {
            DoOnMessage("You pokormile ravlicka. On pokushal.");
        }
    }
}
