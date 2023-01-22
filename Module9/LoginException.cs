using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class LoginException : Exception
    {
        public LoginException()
        {

        }

        public LoginException(string exceptionMessgage) :base(exceptionMessgage)
        {

        }
    }
}
