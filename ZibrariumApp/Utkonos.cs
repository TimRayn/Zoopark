using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class Utkonos : Animal
    {
        public int Eggs { get; set; }
        public Utkonos(string name)
            : base(name)
        {

        }

        public void Bit()
        {
            Console.WriteLine("Huyak! Utkonos otpizdil vas.");
        }

    }
}
