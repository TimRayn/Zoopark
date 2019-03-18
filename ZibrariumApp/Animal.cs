using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ZibrariumApp
{
    public abstract class Animal 
    {
        public string Name { get; set; }
        public int Satiety { get; set; }        //for timer
        private static int _animalCount;
        public event EventHandler<string> OnMessage;
        public event EventHandler OnCreate;
        public event EventHandler<bool> OnStatusChange;       //for timer
        private Timer Golodomor { get; set; }           //for timer

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
        public bool IsHungry
        {
            get => _isHungry;
            set
            {
                //Todo: if(value == true) активувати івент (передати аргументом $"Animal {this} is hungry")
                if (value == true)
                {
                    OnStatusChange.Invoke(this, value);
                }
                _isHungry = value;
            }
        }
        private void CreateTimer()
        {
            Golodomor = new Timer();
            Golodomor.Enabled = true;
            Golodomor.Interval = 10000;
            Golodomor.Elapsed += GolodomorOnElapsed;
            Golodomor.AutoReset = false;
        }
        private void GolodomorOnElapsed(object sender, ElapsedEventArgs e)
        {
            IsHungry = true;
        }

        private Animal()
        {
            var random = new Random();
            Character = random.Next(-100, 100);
            CreateTimer();
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

