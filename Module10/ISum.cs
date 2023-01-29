using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Module10
{
    internal interface ISum<T> where T: INumber<T>
    {
        T Sum(T valueOne, T valueTwo);
    }
}
