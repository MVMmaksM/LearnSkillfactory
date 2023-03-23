using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15
{
    internal class Car
    {
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }     

        public Car(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;            
        }
        public Car()
        {
            
        }
    }
}
