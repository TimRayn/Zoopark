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
        private Zoo Zoo { get; }
        private ILogger Logger { get; }
        private IDataReader Reader { get; }
        
        
        public ZooController(Zoo zoo, ILogger logger, IDataReader reader)
        {
            Reader = reader;
            Logger = logger;
            Zoo = zoo;
        }

        public string GetAnimalList()
        {
            var data = "";

            foreach (var animal in Zoo.Animals)
            {
                data += animal + "\n";
            }

            return data;
        }



        public Animal CreateAnimal()
        {
            Animal animal;

            Logger.LogMessage("Enter animal name:");
            var name = Reader.ReadLine();
            try
            {
                Logger.LogMessage("Choose a race:\n" +
                                  "1 - Penguin;\n" +
                                  "2 - Utkonos;\n" +
                                  "3 - Juravl;\n" +
                                  "4 - Ravlick.");

                var choiceRace = Reader.ReadLine();
                var type = (AnimalType) int.Parse(choiceRace);

                switch (type)
                {
                    case AnimalType.Penguin:
                        animal = new Penguin(name);
                        Zoo.AddNewAnimal(animal);
                        break;
                    case AnimalType.Utkonos:
                        animal = new Utkonos(name);
                        Zoo.AddNewAnimal(animal);
                        break;
                    case AnimalType.Juravl:
                        animal = new Juravl(name);
                        Zoo.AddNewAnimal(animal);
                        break;
                    case AnimalType.Ravlick:
                        animal = new Ravlick(name);
                        Zoo.AddNewAnimal(animal);
                        break;
                    default:
                        throw new Exception("Выберите, блять, из доступных.");
                }
                Logger.LogMessage($"{animal.GetType().Name} {name} добавлен в зоопарк.");

                animal.OnMessage += DoOnMessage;
                animal.OnCreate += AnimalOnOnCreate;
                animal.OnStatusChange += AnimalOnOnStatusChange;
                            animal.OnStatusChange += AnimalCheckIsDead;    

                animal.Create();
                return animal;
            }
            catch (ArgumentOutOfRangeException)
            {
                Logger.LogError("Че, самый умный, блять? выбери из списка доступных рас, пидор.");
                Logger.LogMessage($"Или твой {name} будет НИКЕМ.");
            }
            catch (Exception e)
            {
                Logger.LogError("Ошибка при попытке создать животное.", e);
            }

            return animal = null;
        }

        private void AnimalCheckIsDead(object sender, bool e)
        {
            if (e == true)
            {
                var animal = (Animal) sender;
                Zoo.Animals.Remove(animal);
                Logger.LogMessage($"{animal.Name} die.");
            }
        }

        private void AnimalOnOnStatusChange(object sender, bool e)
        {
            var animal = (Animal) sender;
            Logger.LogMessage("");
        }

        private void AnimalOnOnCreate(object sender, EventArgs e)
        {
            if (Zoo.Animals.Count != 0)
            {
                Logger.LogMessage("Животные выходят пиздить новое мясо.(Нет)");
            }
            
        }

        private void DoOnMessage(object sender, string message)
        {
            var animal = (Animal) sender;
            Logger.LogMessage($"{animal.Name} - {message}");
        }

        public void FeedAnimal()
        {
            if(Zoo.Animals.Count != 0)
            {
                Logger.LogMessage("Доступные для прокорма животные:");

                foreach (var animal in Zoo.Animals)
                {
                    Logger.LogMessage($"{animal.Name} ({animal.GetType().Name})", ConsoleColor.Green);
                }

                Logger.LogMessage("Введите имя того, кого хотите покормить:");

                string name = Reader.ReadLine();
                //Todo: пізніше: зробити через LINQ без foreach
                foreach (var animal in Zoo.Animals)
                {
                    if (animal.Name == name)
                    {
                        animal.Pokormit();
                    }
                    else
                    {
                        Logger.LogMessage("Животного с таким именем нет.", ConsoleColor.Magenta);    
                    }
                }
            }
            else
            {
                Logger.LogMessage("Зоопарк пуст. Сначала добавьте животных.");
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
