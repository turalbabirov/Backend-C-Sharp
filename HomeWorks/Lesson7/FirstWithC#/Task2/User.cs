using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWithC_.Task2
{
    class User
    {
        public User(string name, string surname, string username, string password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }
        protected internal string Name;
        protected internal string Surname;
        protected internal string Username;
        protected internal string Password;
    }
}
