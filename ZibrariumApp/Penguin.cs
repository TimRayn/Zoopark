using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class Penguin : Animal
    {
        public Penguin(string name, int id, int character)
           : base(name, id, character)
        {
            // добавить им чето свое
        }

        public override void Pokormit()
        {
            Console.WriteLine("You pokormile penguina. On pokazal vam middle palec.");
        }

        public void AddNewPenguin()
        {

        }
    }

}
