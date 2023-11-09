using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWithC_.Task2
{
    class Student:User
    {
        public Student(string name, string surname, string username, string password, string status):base(name, surname, username, password)
        {
            if(status == "student")
            {
                if (name == "Tural") Grade = 'A';
                else Grade = 'B';
            }

            Console.WriteLine(
                $"Salam, {Name} {Surname}. Sizin gradiniz: {Grade}"
            );
        }

        protected internal char Grade;

    }
}
