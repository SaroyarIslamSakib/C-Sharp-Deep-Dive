using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence.MethodHiding
{
    public class Dog : Animal
    {
        public new void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
