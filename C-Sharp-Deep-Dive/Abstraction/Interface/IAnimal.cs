using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public interface IAnimal
    {
        string Colour { get; set; }
        void MakeSound();

        public string GetColour()
        {
            return Colour;
        }
    }
}
