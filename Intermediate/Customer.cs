using System;

namespace Intermediate
{
    public class Customer
    {
        public String Name { get; set; }
        public string Address { get; set; }
        public Customer (string name, string address){ Name = name;
            Address= address;
        }

        public override string ToString()
        {
            return Name + ", " + Address;
        }
    }
}