using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstWithC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Task1 - Lesson 10.
            //Person classınız olsun, hər dəfə classdan yeni obyekt yarananda,
            //studentin age - i əvvəlki son yaranan studentin yaşından 1 çox olsun.

            //Məsələn:
            Student tural = new Student();
            Console.WriteLine(tural.Age); //1

            Student suleyman = new Student();
            Console.WriteLine(suleyman.Age); //2

            Student gafar = new Student();
            Console.WriteLine(gafar.Age); //3

            Student semed = new Student();
            Console.WriteLine(semed.Age); //4

            //Not: loop falan istifadə etmək olmaz;
            //yuxarıdakı kodu main methoduna paste edib icra edəndə,
            //komentlərdə yazılan nəticələr çap olunmalıdı:
            //1
            //2
            //3
            //4



            #endregion
        }
    }

    class Student
    {
        private static int _age = 0;
        public int Age;
        public Student()
        {
            Age = ++_age;
        }
    }
}