using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }// свойство без реализации

        public Animal(string name)//конструктор
        {
            Name = name;
        }

        public abstract void Say();// Абстрактный. Нет тела и нет фигурных скобок              
        public void ShowInfo() 
        {
            Console.WriteLine(Name);
            Say();           
        }
    }



    class Cat : Animal
    {
        string name;      
        string say;
        string size;

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name, string say, string size)
           : base(name)
        {
            this.say = say;
            this.size = size;
        }
        public override void Say()
        {
            Console.WriteLine(say);
        }
        public void ShowSize()// как вывести метод из производного класса???
        {
            Console.WriteLine(size);
        }
    }

    class Dog : Animal
    {      
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name)
           : base(name)
        {           
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}

