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
            ZooController zooController = new ZooController(zoo);

            while (true)
            {
                Console.WriteLine("Enter the number, that mean what do you want:\n" +
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
                    case "4":
                        Console.WriteLine(zooController.GetAnimalScroll());
                        break;
                    case "0":
                        break;
                }
            }


            //Animal penguin1 = new Penguin("Andrey", 1, 1);
            //Animal juravl1 = new Juravl("Sanya", 1, 1);
            //Animal utkonos1 = new Utkonos("Gena", 3, 10);
            //// список обьектов класса єнимал
            //List<Animal> animals = new List<Animal>() {penguin1, juravl1, utkonos1};
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
