using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    public class Zoo
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();

        public Zoo()
        {

        }

        public void AddNewAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
    }
}
