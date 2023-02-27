using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    internal class Contact
    {
        public Contact(long phoneNumber, string email)
        {          
            PhoneNumber = phoneNumber;
            Email = email;
        }
        
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
