using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    internal class User
    {
        private int age;
        private string? _login;
        private string? _email;
        public int MyProperty { get; }
        public string? Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Почта должна содержать символ @");
                }
                else
                {
                    _email = value;
                }                
            }
        }


        public string? Login
        {
            get { return _login; }
            set
            {
                if (value?.Length < 3)
                {
                    Console.WriteLine("Логин не может быть меньше 3 символов!");
                }
                {
                    _login = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
