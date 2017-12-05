using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmenttt
{
    class Address
    {
        public Address(string country, string street, string city)
        {
            this.country = country;
            this.street = street;
            this.city = city;
        }
        public string country { get; set; }
        public string street { get; set; }
        public string city { get; set; }
    }
}
