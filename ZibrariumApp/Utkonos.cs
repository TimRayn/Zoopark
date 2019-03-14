using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class Utkonos : Animal
    {
        private ILogger Logger { get; set; }
        public Utkonos(string name)
            : base(name)
        {

        }
        public override void Pokormit()
        {
            Logger.LogMessege("You pokormile utkonosa. Zachem?");
        }

    }
}
