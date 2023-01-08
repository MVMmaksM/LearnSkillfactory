using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class Apple : Fruit
    {
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public Apple(string color)
        {
            Color = color;
        }
        public Apple(string color, decimal price) : this(color)
        {
            Price = price;
        }
    }
}
