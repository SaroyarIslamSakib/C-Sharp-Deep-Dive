using System;
using System.Collections.Generic;
using System.Text;

namespace Methods.Encapsulation
{
    public class Person
    {
        private string _name;
        private string _email;
        private string _phone;


        public void SetName(string name)
        {
            _name = name;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }

        public void SetPhone(string phone)
        {
            _phone = phone;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetEmail()
        {
            return _email;
        }
        public string GetPhone()
        {
            return _phone;
        }
    }
}
