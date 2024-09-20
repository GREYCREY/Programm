using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        readonly int id = 0;
        private string _fullname;
        private string _address;
        public int ID => id;
        public string FullName
        {
            get { return _fullname; }
            set { ValueValidator.LengthValidator(0, 200, value); _fullname = value; }
        }
        public string Address
        {
            get { return _address; }
            set { ValueValidator.LengthValidator(0, 500, value); _address = value; }
        }
        public Customer( string address, string fullName)
        {
            
            FullName = fullName;
            Address = address;
            id++;

        }
    }
}
