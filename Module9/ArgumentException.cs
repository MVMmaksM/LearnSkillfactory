using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class ArgumentException: Exception
    {
        public ArgumentException()
        {

        }

        public ArgumentException(string message): base(message) 
        {

        }
    }
}
