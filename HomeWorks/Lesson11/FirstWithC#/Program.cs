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

            #region Task1 - Lesson 11.
            //<Console App>

            //Person və Employee classınız olsun:
            //Personun İd,Name,Surname,Age, propertyləri olsun.
            //Employee-in bundan əlavə  Salary propertyisi olsun
            //İd ilk persondan 1 olaraq başlasın və hər istifadəçi əlavə olunduqda 1++ artsın

            //CustomCollection Classınız olsun:
            //tip olaraq yalnız Class qəbul etsin və
            //yalnız Person - dan miras alan classlar olsun

            //Proqram run olanda Ekrana 3 seçim çıxsın
            //1) Employee Əlavə Etmək;
            //İstifadəçidən Ad, Soyad, Yaş sourşsun və mütləq hər dəyər ötürülməlidir
            //2) İd-ə görə Employee-ni tapıb ekrana çıxarsın;
            //İd soruşsun
            //bu İd-də istifadəçi varsa qaytarsın console-a
            //yoxdursa "İstifadəçi tapılmadı"
            //3) Bütün Employeelər Ekrana çıxsın

            //Hər əməliyyat sonunda istifadəçidən davam etmək istədiyini soruşsun. əyər..
            //istifadəçi  "yes" daxil edib enter klik edibsə, yenə birinci səhifəyə qayıtsın,
            //"no" yazıb enter klik etdikdə proqram sonlandırılsın


            CustomCollection<Person> allperson = new CustomCollection<Person>();



            #endregion
        }
    }

    class Person
    {
        private static int _id=1;
        public int Id;
        public string Name;
        public string Surname;
        public int Age;

        public Person()
        {
            Id = ++_id;
        }
    }

    class Employee: Person
    {
        public double Salary;
    }

    class CustomCollection<T> where T: class
    {
        
    }
}