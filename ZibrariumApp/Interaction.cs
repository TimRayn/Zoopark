using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    class Interaction
    {
        public string act;
        public void FirstQuestion()
        {
            Console.WriteLine("Enter the number, that mean what do you want:\n" +
                              "1 - Add new animal;\n" +
                              "2 - Feed animal;\n" +
                              "3 - Pet animal;\n" +
                              "0 - Get out from fuking zoo!");
            act = Console.ReadLine();

            switch (act)
            {
                case "1":
                    AddNewAnimal();
                    break;

                case "0":
                    Exit();
                    break;
            }
        }

        public void AddNewAnimal()
        {
            Console.WriteLine("Choose a race:\n" +
                              "1 - Penguin;\n" +
                              "2 - Utkonos;\n" +
                              "3 - Juravl;\n" +
                              "4 - Ravlick.");

            string choiceRace = Console.ReadLine();
            switch (choiceRace)
            {
                case "1":
                    Console.WriteLine("Give him a name:");
                    string name = Console.ReadLine();

                    break;
            }
        }

        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
