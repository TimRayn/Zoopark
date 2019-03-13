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
        private static int _animalCount;

        public int Id { get; }

        private int _character;
        public int Character
        {
            get
            {
                return _character;
            }
            set
            {
                if (value >= -100 && value <= 100) _character = value;
            }
        }
        public bool IsHungry { get; set; }

        private Animal()
        {
            var random = new Random();
            Character = random.Next(-100, 100);
        }

        protected Animal(string name) : this()
        {
            Name = name;
            Id = _animalCount;
            _animalCount++;
        }

        protected Animal(string name, int id) : this()
        {
            Name = name;
            Id = id;

            _animalCount++;
        }

        public virtual void Pokormit()
        {
            Console.WriteLine("You pokormil jivotne.");
        }

        public override string ToString()
        {
            return $"{Id} - {GetType().Name} - {Name} - {Character}";
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

