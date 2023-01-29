using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    internal class Logger : ILogger
    {
        void ILogger.Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{DateTime.Now} error: {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        void ILogger.Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n{DateTime.Now} info: {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        void ILogger.Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{DateTime.Now} error: {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
