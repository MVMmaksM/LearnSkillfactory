using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    internal interface IWriter
    {
        public int MyProperty { get; set; }
        void Write() => Console.WriteLine("Hello");
    }
}
