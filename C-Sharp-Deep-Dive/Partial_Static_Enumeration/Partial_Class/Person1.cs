using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Static_Enumeration.Partial_Class
{
    public partial class Person
    {
        public string Name { get; set; }

        internal partial void ShowName();
    }
}
