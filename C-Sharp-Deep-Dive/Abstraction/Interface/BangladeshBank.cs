using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class BangladeshBank : IBangladeshBank
    {
        public void ShowName()
        {
            Console.WriteLine("Bangladesh bank");
        }
        public void ShowBangladeshiTax()
        {
            Console.WriteLine("1 lakh Taka");
        }
    }
}
