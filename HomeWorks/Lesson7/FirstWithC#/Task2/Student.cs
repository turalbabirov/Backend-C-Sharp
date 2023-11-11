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
        protected internal char Grade;
        public Student(string name, string surname, string username, string password, string status,char grade):base(name, surname, username, password)
        {
            Grade = grade;
            //if (status == "student")
            //{
            //    if (name == "Tural") Grade = 'A';
            //    else Grade = 'B';
            //}

            //Console.WriteLine(
            //    $"Salam, {Name} {Surname}. Sizin gradiniz: {Grade}"
            //);
        }

        

    }
}
