using System;

namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");

            int[,] array = new int [4,3]{ { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }


            //Console.Write($"Последняя буква вашего имени {name[name.Length - 1]}");

            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //var color = Console.ReadLine();           


            //switch (color)
            //{
            //    case "red":
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is red!");
            //        break;

            //    case "green":
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is green!");
            //        break;

            //    case "cyan":
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //        Console.ForegroundColor = ConsoleColor.Black;
            //        break;

            //    default:
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.ForegroundColor = ConsoleColor.Red;

            //        Console.WriteLine("Your color is yellow!");
            //        break;
            //}

        }
    }
}