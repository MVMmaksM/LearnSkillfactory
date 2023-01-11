using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    internal class Rectangle
    {
        public int a { get; set; }
        public int b { get; set; }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Rectangle(int ab)
        {
            a = b = ab;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public int Square()=> a*b;
    }
}
