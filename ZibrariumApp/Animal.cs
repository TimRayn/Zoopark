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
        private ILogger Logger { get; set; }

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

        private Animal(ILogger logger)
        {
            Logger = logger;
            var random = new Random();
            Character = random.Next(-100, 100);
        }

        protected Animal(ILogger logger,string name) : this(logger)
        {
            Name = name;
            Id = _animalCount;

            _animalCount++;
        }

        protected Animal(ILogger logger, string name, int id) : this(logger)
        {
            Name = name;
            Id = id;

            _animalCount++;
        }

        public abstract void Pokormit();

        public override string ToString()
        {
            return $"ID: {Id};  Race: {GetType().Name};  Name: {Name};  Current character: {Character}";
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

