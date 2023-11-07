using Microsoft.VisualBasic.FileIO;
using System;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace FirstWithC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Task1 - Lesson 5:

            //Person classı olsun
            //Name, Surname, Age, İsAdult propertyləri olsun.
            //Və name, surname, age parametrlərini qəbul edən Constructoru olsun.
            //Obyekt yarananda əgər yaşı 18dən böyükdürsə İsAdult - ı true əks halda false olsun.

            Person tural = new Person("Tural", "Babirov", 30);
            tural.Result();
            Console.WriteLine("----------");

            #endregion

            #region Task2 - Lesson 5.:
            //Brend,Model,İl,FuelType və Rəng property-ləri olan Car klasınız olsun
            //Object yarananda Brend,Model,FuelType,İl və Rəng attributlarını ötürün.
            //Objectdə PrintInfo Metodunuz olsun onu call edən zaman bütün məlumatları ekrana çap etsin


            Car masin = new Car
            {
                Brend = "BMW",
                Model = "X6",
                Year = 2012,
                FuelType = "Benzin",
                Color = "White",
            };

            masin.PrintInfo();
            Console.WriteLine("----------");

            #endregion

            #region Task3 - Lesson 5.:
            //Car və Motorcycle adlı klasınız olsun və Model, Brend, Year, MaxSpeed propertyləri olsun
            //bundan əlavə Car klasının NumSeats,Motorcycle klasının isə HasSidecar propertyisi olsun
            //Obyekt yarandıqdan sonra Əgər sürət 110 - dan böyükdürsə ekrana "Suret oldurur"
            //əks halda "Bele davam edin" yazısı çap olunsun

            Motorcycle motosiklet = new Motorcycle
            {
                Brend = "MotoX",
                Model = "XMoto",
                Year = 2021,
                MaxSpeed = 210,
            };
            Console.WriteLine(motosiklet.HasSidecar());
            Console.WriteLine("----------");

            #endregion

            #region Task4 - Lesson 5.:
            //User classı olsun, içində fantaziyanıza görə propertylər və əsas..
            //string Name; string Password; propertyləri olsun. Və public bool IsPasswordValid() methodu olsun.
            //Bu method, əgər passvordun uzunluğu 6dan qısadırsa, və ya passwordun daxilində rəqəm yoxdursa
            //və ya əgər Passvordun daxilində Name vardırsa false, əks halda true return eləsin.
            //Valid password uzunluğu 6dan uzun,içində rəqəm olan və..
            //userin adının passvordun içində keçmədiyi passvorddur.

            //Məsələn:
            //name = Mirqubad
            //password= 123mirqubad  !123
            //-> false  -> paswordda name deyeri var

            //name = Mirqubad
            //password= akbarov_m
            //-> false  -> paswordda reqem yoxdur

            //name = Mirqubad
            //password = 123akbarov123
            //-> true  


            User mirqubad = new User("MirQubad", "690mirGubad");

            if( mirqubad.IsPasswordValid() )
            {
                Console.WriteLine("Qeydiyyat tamamlandı!");
            } else
            {
                Console.WriteLine("Yanlış şifrə daxil etdiniz.");
            }
             
            #endregion
        }
    }

    class Person
    {
        public Person(string Name, string Surname, byte Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.IsAdult = Age > 18 ? true : false;
        }

        public string Name;
        public string Surname;
        public byte Age;
        public bool IsAdult;
        public void Result()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Adult: {IsAdult}");
        }
    }

    class Car
    {
        public string Brend;
        public string Model;
        public int Year;
        public string FuelType;
        public string Color;
        //Task3 üçün əlavə propertler:
        public string MaxSpeed;
        public string NumSeats;
        public void PrintInfo()
        {
            Console.WriteLine($"Brend: {Brend}; Model: {Model}, Year: {Year}, FuelType: {FuelType}, Color: {Color}");
        }
    }

    class Motorcycle
    {
        public string Brend;
        public string Model;
        public int Year;
        public int MaxSpeed;
        public string HasSidecar()
        {
            if (MaxSpeed > 110) return "Sürət öldürür!";

            return "Bele davam edin";
        }

    }
}