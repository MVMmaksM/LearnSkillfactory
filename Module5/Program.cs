namespace Module5
{
    internal class Program
    {      
        public static string[] CreateArrayPets(int amountPets)
        {
            string[] arrayPets = new string[amountPets];

            for (int i = 0; i < arrayPets.Length; i++)
            {
                Console.WriteLine("\nВведите имя питомца");
                arrayPets[i] = Console.ReadLine() ?? "Нет имени";
            }

            return arrayPets;
        }
        public static string[] CreateArrayFavColors(int amountColors)
        {
            string[] arrayFavColors = new string[amountColors];

            for (int i = 0; i < arrayFavColors.Length; i++)
            {
                Console.WriteLine("\nВведите цвет");
                arrayFavColors[i] = Console.ReadLine() ?? "Нет цвета";
            }

            return arrayFavColors;
        }
        public static bool CheckNumber(string number, out int correctNumber)
        {
            if (int.TryParse(number, out int intNumber))
            {
                if (intNumber > 0)
                {
                    correctNumber = intNumber;
                    return true;
                }
            }

            Console.WriteLine("Введено некорректное число!");
            correctNumber = default;
            return false;
        }
        public static bool CheckAge(string age, out int correctAge)
        {
            if (int.TryParse(age, out int intAge))
            {
                if (intAge > 0 && intAge < 100)
                {
                    correctAge = intAge;
                    return true;
                }
            }

            Console.WriteLine("Некорректный возраст");
            correctAge = default;
            return false;
        }
        public static bool CheckName(string name, out string correctName)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Имя не может быть пустым!");
                correctName = string.Empty;
                return false;
            }
            else if (!int.TryParse(name, out int result))
            {
                correctName = name;
                return true;
            }


            Console.WriteLine("Некорректное имя!");
            correctName = string.Empty;
            return false;
        }
        public static void ShowUser((string? name, string? surname, byte age, string[]? namePets, string[] favColors) user)
        {
            Console.WriteLine("\nИнофрмация о пользователе:");
            Console.WriteLine($"Имя: {user.name}");
            Console.WriteLine($"Фамилия: {user.surname}");
            Console.WriteLine($"Возраст: {user.age}");

            void ShowArray(string[] array)
            {
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }

            if (user.namePets != null)
            {
                Console.WriteLine($"Количество питомцев: {user.namePets.Length}");
                Console.WriteLine("Имена питомцев: ");

                ShowArray(user.namePets);
            }

            if (user.favColors != null)
            {
                Console.WriteLine($"Количество любимых цветов: {user.favColors.Length}");
                Console.WriteLine("Цвета: ");

                ShowArray(user.favColors);
            }
        }
        public static (string? name, string? surname, byte age, string[]? namePets, string[] favColors) GetUser()
        {
            (string? name, string? surname, byte age, bool havePet, int amountPet, string[] namePets, int amountFavColors, string[] favColors) user;

            string correctName = string.Empty;
            do
            {
                Console.WriteLine("\nВведите имя");

            } while (!CheckName(Console.ReadLine(), out correctName));

            user.name = correctName;


            Console.WriteLine("\nВведите фамилию");
            user.surname = Console.ReadLine();

            int correctAge = 0;

            do
            {
                Console.WriteLine("\nВведите возраст");

            } while (!CheckAge(Console.ReadLine(), out correctAge));

            user.age = (byte)correctAge;

            Console.WriteLine("\nУ вас есть питомцы? \nВведите Да или Нет");

            user.havePet = Console.ReadLine().ToLower() == "да" ? true : false;


            int correctAmount = 0;
            user.namePets = null;

            if (user.havePet)
            {
                do
                {
                    Console.WriteLine("\nВведите количество питомцев");

                } while (!CheckNumber(Console.ReadLine(), out correctAmount));

                user.namePets = CreateArrayPets(correctAmount);
            }

            int correctAmountColors = 0;
            do
            {
                Console.WriteLine("\nВведите количество любимых цветов");

            } while (!CheckNumber(Console.ReadLine(), out correctAmountColors));

            user.amountFavColors = correctAmountColors;

            user.favColors = CreateArrayFavColors(correctAmountColors);

            return (user.name, user.surname, user.age, user.namePets, user.favColors);
        }

        static void Main(string[] args)
        {
            //ShowUser(GetUser());

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(long.MaxValue);
        }
    }
}
