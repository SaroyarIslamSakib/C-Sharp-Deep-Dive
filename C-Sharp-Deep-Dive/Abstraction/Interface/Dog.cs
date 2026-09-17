using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Dog : IAnimal
    {
        public string Colour { get; set; }
        public void MakeSound()
        {
            Console.WriteLine("Bark..........");
        }
    }
}
