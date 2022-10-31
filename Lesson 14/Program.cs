using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Cat ("Мурка", "Мяу", "Маленькая");
            Cat cat = new Cat("Мурка", "Мяу", "Маленькая");
            cat.ShowInfo();

            Dog dog = new Dog("Бобик");
            dog.ShowInfo(); 
            Console.ReadKey();  
        }
    }
}
