using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class ZooController
    {
        private readonly Zoo _zoo;
        //Todo: спрасіть Сергія
        private ILogger Logger { get; set; }
        private IDataReader Reader { get; set; }
        
        public ZooController(Zoo zoo, ILogger logger, IDataReader reader)
        {
            Reader = reader;
            Logger = logger;
            _zoo = zoo;
        }

        public string GetAnimalList()
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
            //Todo: обгорнути в try..catch, логувати помилку
            Animal animal;
         

            Logger.LogMessege("Choose a race:\n" +
                              "1 - Penguin;\n" +
                              "2 - Utkonos;\n" +
                              "3 - Juravl;\n" +
                              "4 - Ravlick.");

            var choiceRace = Reader.ReadLine();
            var type = (AnimalType)int.Parse(choiceRace);

            Logger.LogMessege("Enter animal name:");
            var name = Reader.ReadLine();

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

            //Todo: здійснити підписку на івент
            return animal;
        }

        private void LogAnimalStatus(object sender, EventArgs args)
        {
            Logger.LogMessege(sender as string);
        }

        public void FeedAnimal()
        {
            Logger.LogMessege("Доступные для прокорма животные:");

            foreach (var animal in _zoo.Animals)
            {
                Logger.LogMessege($"{animal.Name}({animal.GetType().Name})");
            }

            Logger.LogMessege("Введите имя того, кого хотите покормить:");

            string name = Reader.ReadLine();
            //Todo: пізніше: зробити через LINQ без foreach
            foreach (var animal in _zoo.Animals)
            {
                if (animal.Name == name)
                {
                    animal.Pokormit();
                }
                else
                {
                    Logger.LogMessege("Животного с таким именем нет.");    
                }
            }

        }
        
        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
