using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
        public BaseClass()
        {

        }

        public string Name;
        protected string Description;
        private int value;

        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }       
    }
}
