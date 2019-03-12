using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibrariumApp
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Id { get; set; }

        private int _character;
        public int Character
        {
            get
            {
                return Character;
            }
            set
            {
                if (value >= -100 && value <= 100) _character = value;
            }
        }
        public bool IsHungry { get; set; }

        protected Animal(string name, int id, int character)
        {
            Name = name;
            Id = id;
            Character = character;
        }

        public virtual void Pokormit()
        {
            Console.WriteLine("You pokormil jivotne.");
        }
    }

    //public class Visitor : Animal
    //{
    //    public bool HaveAIceCream { get; set; }
    //    public Visitor(string name, int id, int character, bool isHungry, bool haveAIceCream)
    //        : base(name, id, character, isHungry)
    //    {
    //        HaveAIceCream = haveAIceCream;
    //    }
    //}
}

//
//
//  Создавать для каждого класса, даже обьектов энимал свой файл

