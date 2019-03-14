using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class Juravl : Animal
    {
        private ILogger Logger { get; set; }
        public Juravl(string name)
            : base(name)
        {

        }
        public override void Pokormit()
        {
            Logger.LogMessege("You pokormile juravlya. Iz vazi. On posmotrel na vas osujdayushche.");
        }
    }
}
