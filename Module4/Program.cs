using System;

namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string? name, string? lastname, string? login, int loginLength, bool haspet, byte age, string?[] favcolors) user;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите имя");

                user.name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                user.lastname = Console.ReadLine();

                Console.WriteLine("Введите логин");

                user.login = Console.ReadLine();

                user.loginLength = user.login?.Length ?? default;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                user.haspet = Console.ReadLine() == "Да" ? true : false;

                Console.WriteLine("Введите возраст пользователя");

                user.age = byte.Parse(Console.ReadLine());

                Console.WriteLine("Введите три любимых цвета пользователя");

                user.favcolors = new string[3];

                for (int k = 0; k < user.favcolors.Length; k++)
                {
                    user.favcolors[k] = Console.ReadLine();
                }
            }
        }
    }
}