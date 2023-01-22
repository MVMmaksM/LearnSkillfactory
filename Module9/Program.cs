namespace Module9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 2
            SortList sortList = new();            
            sortList.SortDescending += (string[] lastNames) =>
            {
                Array.Sort(lastNames);
                Array.Reverse(lastNames);

                return lastNames;
            };

            sortList.SortAscending += (string[] lastNames) =>
            {
                Array.Sort(lastNames);
                return lastNames;
            };

            string[] lastNames = new string[5];

            try
            {
                for (int i = 0; i < lastNames.Length; i++)
                {
                    Console.WriteLine("Введите фамилию: ");
                    lastNames[i] = Console.ReadLine();
                }

                Console.WriteLine("Введите номер сортировки: 1 - по возрастанию, 2 - по убыванию");
                sortList.OnSortArray(Convert.ToInt32(Console.ReadLine()), ref lastNames);

                foreach (var item in lastNames)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            //задание 1
            Exception[] exceptions =
            {
                new ArgumentException("Недопустимый аргумент!"),
                new ArgumentNullException("Передаваемый аргумент является null!"),
                new OverflowException("Значение выходит за пределы диапазона типа данных"),
                new LoginException("Неверный логин!"),
                new DivideByZeroException("Нельзя делить на ноль!")
            };

            foreach (var exp in exceptions)
            {
                try
                {
                    throw exp;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}