using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15
{
    internal class Contact
    {
        public string? Name { get; set; }
        public long Phone { get; set; }
        public string? Email { get; set; }

        public Contact(string name, long number, string email)
        {
            Name = name;
            Phone = number;
            Email = email;
        }
    }
}
