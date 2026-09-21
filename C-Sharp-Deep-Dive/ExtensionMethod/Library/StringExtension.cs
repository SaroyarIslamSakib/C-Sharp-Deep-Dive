using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod.Library
{
    public static class StringExtension
    {
        public static void Show(this string city)
        {
            Console.WriteLine(city);
        }
    }
}
