using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching.Library
{
    public class Outer
    {
        public string Data { get; set; } = "Temp";
        public class Inner
        {
            public Outer outer { get; set; } = new();
            public void Test()
            {
                Console.WriteLine("Inner Class used..");
            }
        }
    }

    public class InnerChild : Outer.Inner
    {

    }
}
