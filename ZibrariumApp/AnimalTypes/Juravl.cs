using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    public class Juravl : Animal
    {
   
        public Juravl(string name)
            : base(name)
        {

        }
        public override void Pokormit()
        {
            DoOnMessage("You pokormile juravlya. Iz vazi. On posmotrel na vas osujdayushche.");
        }
    }
}
