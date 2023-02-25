using System;
using System.Collections;
using System.Text;

namespace Module13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите текст:");
                var text = Console.ReadLine();

                var sing = new char[] { ' ', '.', ',' };
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                
                var chars = text?.ToCharArray();
               
                HashSet<char> set = new HashSet<char>(chars);

                bool isNumbers = set.Overlaps(numbers);
                Console.WriteLine($"Коллекция содержит цифры: {isNumbers}");

                set.ExceptWith(sing);
                Console.WriteLine($"Длина коллекции: {set.Count}\n");
            }                    
        }

        public static List<string> GetMissing(List<string> month, ArrayList missing)
        {
            var result = new List<string>();

            foreach (var miss in missing)
            {
                if ((miss is string) && (!month.Contains(miss)))
                {
                    result.Add((string)miss);
                }
            }

            foreach (var item in result)
            {
                missing.Remove(item);
            }

            month.AddRange(result);

            return month;
        }
        public static void AddContact(List<Contact> contacts, Contact contact)
        {
            bool isExist = false;

            foreach (var con in contacts)
            {
                if (con.Name == contact.Name)
                {
                    isExist = true;
                }
            }

            if (!isExist)
            {
                contacts.Add(contact);
            }
        }

        static bool isSortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] <= array[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static ArrayList NewArrayList(ArrayList input)
        {
            int sum = default(int);
            StringBuilder text = new StringBuilder();
            var outputArrList = new ArrayList();

            foreach (var value in input)
            {
                if (value is int)
                {
                    sum += (int)value;
                }
                else if (value is string)
                {
                    text.Append(value);
                }
            }

            outputArrList.Add(sum);
            outputArrList.Add(text);

            return outputArrList;
        }
    }
}