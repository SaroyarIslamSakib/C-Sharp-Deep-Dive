using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod.Library
{
    public static class StudentExtension
    {
        public static string GetDisplayName(this Student student,string message)
        {
            return message + student.Name.ToUpper();
        }
    }
}
