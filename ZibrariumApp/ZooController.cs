using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class ZooController
    {
        private readonly Zoo _zoo;

        public string act;

        public ZooController(Zoo zoo)
        {
            _zoo = zoo;
        }

        public string GetAnimalScroll()
        {
            var data = "";

            foreach (var animal in _zoo.Animals)
            {
                data += animal + "\n";
            }

            return data;
        }


        public Animal CreateAnimal()
        {
            Animal animal = null;

            Console.WriteLine("Choose a race:\n" +
                              "1 - Penguin;\n" +
                              "2 - Utkonos;\n" +
                              "3 - Juravl;\n" +
                              "4 - Ravlick.");

            var choiceRace = Console.ReadLine();
            var type = (AnimalType)int.Parse(choiceRace);

            Console.WriteLine("Enter animal name");
            var name = Console.ReadLine();

            switch (type)
            {
                case AnimalType.Penguin:
                    animal = new Penguin(name);
                    _zoo.AddNewAnimal(animal);
                    break;
                case AnimalType.Utkonos:
                    animal = new Utkonos(name);
                    _zoo.AddNewAnimal(animal);
                    break;
                case AnimalType.Juravl:
                    animal = new Juravl(name);
                    _zoo.AddNewAnimal(animal);
                    break;
                case AnimalType.Ravlick:
                    animal = new Ravlick(name);
                    _zoo.AddNewAnimal(animal);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return animal;
        }

        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
