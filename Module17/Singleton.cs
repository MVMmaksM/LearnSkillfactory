using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    public class Singleton
    {
        private static Singleton Instance;
        public string? Name { get; private set; }

        private Singleton(string name)
        {
            Name = name;
        }

        public static Singleton GetInstance(string name) 
        {
            if (Instance is null)
            {
                Instance = new Singleton(name);
            }

            return Instance;
        }
    }
}
