using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var zoo = new Zoo();
            ILogger Logger = new ConsoleLogger();
            IDataReader Reader = new ConsoleLogger();
            ZooController zooController = new ZooController(zoo, Logger, Reader);

            try
            {
                while (true)
                {
                    Logger.LogMessege("Enter the number, that mean what do you want:\n" +
                                      "1 - Add new animal;\n" +
                                      "2 - Feed animal;\n" +
                                      "3 - Pet animal;\n" +
                                      "0 - Get out from fuking zoo!");
                    var act = Console.ReadLine();

                    switch (act)
                    {
                        case "1":
                            var animal = zooController.CreateAnimal();
                            break;
                        case "2":
                            zooController.FeedAnimal();
                            break;
                        case "4":
                            Logger.LogMessege(zooController.GetAnimalList());
                            break;
                        case "0":
                            break;
                    }
                }
            }
            catch
            {
                Logger.LogMessege("Vidimo, oshibka...");
                Console.ReadKey();
            }

            //// список обьектов класса єнимал
            //List<Animal> animals = new List<Animal>();
            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //penguin1.Pokormit();
            //juravl1.Pokormit();
            Console.ReadKey();
        }
    }
}
