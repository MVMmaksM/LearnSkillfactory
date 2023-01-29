using System.Diagnostics;
using System.Reflection;

namespace Module10
{
    internal class Program
    {
        public static ILogger? Logger;
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Logger = new Logger();

                Console.WriteLine("Введите целое число 1:");
                var numberOne = int.Parse(Console.ReadLine());

                Console.WriteLine("\nВведите целое число 2:");
                var numberTwo = int.Parse(Console.ReadLine());

                ISum<int> baseCalculator = new BaseCalculator(Logger);

                Console.WriteLine($"\nСумма чисел {numberOne} и {numberTwo}: {baseCalculator.Sum(numberOne, numberTwo)}");
            }
            catch (FormatException ex)
            {               
                Logger?.Error($"Неверный формат аргумента\n{ex.Message}");               
            }
            catch (Exception ex)
            {
                Logger?.Error($"Необработанное исключение\n{ex.Message}");
            }
        }
    }
}