using System;

namespace Module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<User> users = new()
                {
                    new User {Login = "User1", Name= "Иван", IsPremium = true},
                    new User {Login = "User2", Name= "Дмитрий", IsPremium = true},
                    new User {Login = "User3", Name= "Константин", IsPremium = false},
                    new User {Login = "User4", Name= "Вячеслав", IsPremium = false},
                    new User {Login = "User5", Name= "Михаил", IsPremium = true},
                };

                for (int i = 0; i < users.Count; i++)
                {
                    Console.WriteLine($"\nДобрый день, {users[i].Name}!");

                    if (!users[i].IsPremium)
                    {
                        ShowAds();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}