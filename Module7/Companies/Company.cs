using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Companies
{
    internal abstract class Company:IShowInfo
    {
        public string? Name { get;}
        public virtual string? Description { get;}
        public virtual string? Address { get;}
        public virtual string? PhoneNumber { get;}
        public virtual string? Email { get; }
        public virtual string? Site { get; set; }

        public Company(string name, string address, string phoneNumber, string description = "Не указано", string email = "Не указан", string site = "Не указан")
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Description = description;
            Email = email;
            Site = site;
        }      
        public void ShowInfo()
        {
            Console.WriteLine($"Наименование организации: {Name}\nАдрес: {Address}\nНомер телефона: {PhoneNumber}\nEmail: {Email}\nОписание: {Description}\nСайт: {Site}");
        }
    }
}
