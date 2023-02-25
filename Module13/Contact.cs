using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    internal class Contact
    {
        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
