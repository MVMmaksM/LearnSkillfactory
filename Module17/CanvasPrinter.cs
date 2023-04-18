using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    internal class CanvasPrinter : IPainter
    {
        public void Paint() => Console.WriteLine("Печать на холсте");
    }
}
