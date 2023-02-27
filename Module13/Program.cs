using System;
using System.Collections;
using System.Text;
using System.Xml;

namespace Module13
{
    internal class Program
    {
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<string, Contact>()
        {
            ["Макс"] = new Contact(89003795411, "vaganov.maksim@mail.ru"),
            ["Иван"] = new Contact(89005548988, "vaganov.maksim@mail.ru"),
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Список контаков:");
            ShowContacts();

            var isAddContact = PhoneBook.TryAdd("Дмитрий", new Contact(89366655545, "@email.ru"));
            Console.WriteLine($"\nКонтакт добавлен: {isAddContact}");
            ShowContacts();

            if (PhoneBook.TryGetValue("Дмитрий", out Contact? contact))
            {
                contact.PhoneNumber = 8900000000;
                Console.WriteLine("Контакт изменен");
            }

            Console.WriteLine("\nСписок с изсененным контактом");
            ShowContacts();

        }

        public static void ShowContacts() 
        {
            foreach (var contact in PhoneBook)
            {
                Console.WriteLine($"Имя: {contact.Key} телефон: {contact.Value.PhoneNumber} Email: {contact.Value.Email}");
            }
        }
    }
}