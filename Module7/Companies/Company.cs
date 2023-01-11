using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Companies
{
    internal abstract class Company
    {
        public string? Name { get;}
        public virtual string? Description { get;}
        public virtual string? Address { get;}
        public virtual string? PhoneNumber { get;}
        public virtual string? Email { get; }

        public Company(string name, string address, string phoneNumber, string description = "Неизвестно", string email = "Неизвестно")
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Description = description;
            Email = email;
        }

        public virtual void ShowInfoCompany() 
        {
            Console.WriteLine($"Наименование организации: {Name}\nАдрес: {Address}\nНомер телефона: {PhoneNumber}\nEmail: {Email}\nОписание: {Description}");
        }
    }
}
