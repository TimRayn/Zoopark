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
            Zoo zoo = new Zoo();
            ILogger Logger = new TxtLogger();
            IDataReader Reader = new DataReader();
            ZooController zooController = new ZooController(zoo, Logger, Reader);

            try
            {
                while (true)
                {
                    Logger.LogMessage("\nEnter the number, that mean what do you want:\n" +
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
                        case "3":
                            Logger.LogMessage("Эту функцию еще не завезли.", ConsoleColor.Yellow);
                            break;
                        case "4":
                            Logger.LogMessage(zooController.GetAnimalList());
                            break;
                        case "0":
                            zooController.Exit();
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Logger.LogMessage($"Ошибка в мейне.\nError:\n{e}", ConsoleColor.Red);
                Console.ReadKey();
            }


            Console.ReadKey();
        }
    }
}
