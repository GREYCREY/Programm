using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model.Classes
{
     class Contacts
    {
        private string _name;
        private string _surname;
        private string _phoneNumber;
        private string NameOfContact
        {
            get { return _name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _name = value;
            }
        }
        private string SurnameOfContact
        {
            get { return _surname; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _surname = value;
            }
        }
        private string PhoneNumberOfContact
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length == 0 && value.Length > 11) throw new ArgumentException();
                _phoneNumber = value;
            }
        }
        public Contacts()
        {
            NameOfContact = "Алексий";
            SurnameOfContact = "Нечаев";
            PhoneNumberOfContact = "+88005353535";

        }
        public Contacts(string name, string surname, string phoneNumber)
        {
            NameOfContact = name;
            SurnameOfContact = surname;
            PhoneNumberOfContact = phoneNumber;
            
        }
    }
}
