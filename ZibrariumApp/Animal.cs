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
        public event EventHandler<string> OnMessage;
        public event EventHandler OnCreate;
        //Todo: створити таймер по якому тварина буде голоднішати
        //Todo: створити івент OnStatusChange
        //Todo: створити проперті Satiety, яка буде мінусуватись в методі таймеру


        protected void DoOnMessage(string message)
        {
            OnMessage.Invoke(this, message);
        }


        public int Id { get; }

        private int _character;
        public int Character
        {
            get => _character;
            set
            {
                if (value >= -100 && value <= 100) _character = value;
            }
        }

        private bool _isHungry;
        public bool IsHungry { get => _isHungry;
            set
            {
                //Todo: if(value == true) активувати івент (передати аргументом $"Animal {this} is hungry")
                _isHungry = value;
            }
             }

        private Animal()
        {
            //Logger = logger;
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

        protected Animal(string name, int id, int character) : this()
        {
            Name = name;
            Id = id;
            Character = character;

            _animalCount++;
        }

        public void Create()
        {
            OnCreate?.Invoke(this, null);
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

