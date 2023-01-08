using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class DerivedClass:BaseClass
    {
        private int counter;
        public override int Counter 
        {
            get => counter;

            set
            {
                if (value > 0)
                {
                    counter = value;
                }
                else 
                {
                    Console.WriteLine("Не может быть еньше 0");
                }
            } 
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}
