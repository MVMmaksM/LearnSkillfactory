using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Module7.Companies;

namespace Module7.Manufacturers
{
    internal abstract class Manufacturer : Company
    {
        public string? Country { get; }
        protected Manufacturer(string name, string address, string phoneNumber, string country, string description = "Не указано", string email = "Не указан", string site = "Не указан") : base(name, address, phoneNumber, description, email, site)
        {
            Country = country;
        }      
    }
}
