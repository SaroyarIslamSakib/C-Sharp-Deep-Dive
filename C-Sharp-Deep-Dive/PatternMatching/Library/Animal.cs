using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching.Library
{
    public class Animal
    {
        public string? Colour { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}
