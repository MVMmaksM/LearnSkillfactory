using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    internal class TrafficLight
    {
        private string? _color;
        private void ChangeColor(string color) => _color = color;
        public string? GetColor() => _color;
    }
}
