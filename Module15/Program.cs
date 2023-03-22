namespace Module15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>
            {
                // добавляем контакты
                new Contact("Игорь", 79990000001, "igor@example.com"),
                new Contact("Сергей", 79990000010, "serge@example.com"),
                new Contact("Анатолий", 79990000011, "anatoly@example.com"),
                new Contact("Валерий", 79990000012, "valera@example.com"),
                new Contact("Сергей", 799900000013, "serg@gmail.com"),
                new Contact("Иннокентий", 799900000013, "innokentii@example.com")
            };

            var groupContact = phoneBook.GroupBy(contact => contact?.Email?.Split("@").Last());

            var result = phoneBook[0]?.Email?.Split("@").Last();

            Console.WriteLine(result);


            //foreach (var group in groupContact)
            //{
            //    Console.WriteLine($"Группа: {group.Key}");

            //    foreach (var contact in group)
            //    {
            //        Console.WriteLine("Контакты группы:");
            //        Console.WriteLine($"Имя: {contact.Name}");
            //        Console.WriteLine($"Телефон: {contact.Phone}");
            //        Console.WriteLine($"Email: {contact.Email}");
            //        Console.WriteLine();
            //    }
            //}
        }
        static double Average(int[] numbers)
        {
            return numbers.Sum() / numbers.Length;
        }
        static int IsCorrectPhoneNumber(List<Contact> contacts)
        {
            var result = (from contact in contacts
                          let phoneNumber = contact.Phone.ToString()
                          where phoneNumber.Length != 11 || phoneNumber.StartsWith('7')
                          select contact).Count();

            return contacts.Where(c => !c.Phone.ToString().StartsWith('7')).Count(c => c.Phone.ToString().Length < 11);
        }

        static long Factorial(int number)
        {
            var numbers = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                numbers.Add(i);
            }

            numbers.Count(x => x > 25);
            return numbers.Aggregate((x, y) => x * y);
        }
    }
}