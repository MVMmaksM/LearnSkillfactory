using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Module10
{
    internal class BaseCalculator : ISum<int>, ISum<double>, ISum<float>, ISum<decimal>, ISum<long>, ISum<byte>
    {
        public ILogger Logger { get; }
        public BaseCalculator(ILogger logger)
        {
            Logger = logger;
        }
        int ISum<int>.Sum(int valueOne, int valueTwo)
        {
            Logger.Info($"Вызван метод {MethodBase.GetCurrentMethod()?.Name}");
            return valueOne + valueTwo;
        }

        double ISum<double>.Sum(double valueOne, double valueTwo)
        {
            Logger.Info($"Вызван метод {MethodBase.GetCurrentMethod()?.Name}");
            return valueOne + valueTwo;
        }

        float ISum<float>.Sum(float valueOne, float valueTwo)
        {
            Logger.Info($"Вызван метод {MethodBase.GetCurrentMethod()?.Name}");
            return valueOne + valueTwo;
        }

        decimal ISum<decimal>.Sum(decimal valueOne, decimal valueTwo)
        {
            Logger.Info($"Вызван метод {MethodBase.GetCurrentMethod()?.Name}");
            return valueOne + valueTwo;
        }

        long ISum<long>.Sum(long valueOne, long valueTwo)
        {
            Logger.Info($"Вызван метод {MethodBase.GetCurrentMethod()?.Name}");
            return valueOne + valueTwo;
        }

        byte ISum<byte>.Sum(byte valueOne, byte valueTwo)
        {
            Logger.Info($"Вызван метод {MethodBase.GetCurrentMethod()?.Name}");
            return (byte)(valueOne + valueTwo);
        }
    }
}
