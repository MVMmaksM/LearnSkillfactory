namespace Module15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
                new Contact() { Name = "Андрей", Phone = 79994500508 },
                new Contact() { Name = "Сергей", Phone = 799990455 },
                new Contact() { Name = "Иван", Phone = 79999675334 },
                new Contact() { Name = "Игорь", Phone = 8884994 },
                new Contact() { Name = "Анна", Phone = 665565656 },
                new Contact() { Name = "Василий", Phone = 3434 },
                new Contact() { Name = "Василий", Phone = 3434 }
            };

            Console.WriteLine(IsCorrectPhoneNumber(contacts));
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