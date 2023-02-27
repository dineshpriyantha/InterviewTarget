using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTarget.SOLID
{
    public class Animal
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public void MakeSound()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} animal makes s sound");
        }
    }

    public class Dog : Animal
    {
        public string? Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine($"Breed: {Breed} Bow Bow");
        }
    }

    public class Cat : Animal
    {
        public string? FurColor { get; set; }
        public void Meow()
        {
            Console.WriteLine($"FurColor: {FurColor} Meow Meow");
        }
    }
}
