using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 - Lab5:
            //1.Telebeleri qiymetine gore siralayin(evvel yuksekler)
            //Student classiniz olacaq
            //(List ve onun methodlarindan istifade edin)
            //Student classiniz olacaq: Name ve Grade propertyleri olacaq

            List<Student> students = new List<Student>();
            students.Add(new Student("Semed", 99.99));
            students.Add(new Student("Qafar", 70));
            students.Add(new Student("Ruslan", 50));

            //Variant 1:
            //students.Sort((x, y) => y.Grade.CompareTo(x.Grade));
            //foreach (Student deyer in students)
            //{
            //    Console.WriteLine(deyer.Grade);
            //}

            //Variant 2:
            foreach (Student deyer in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(deyer.Grade);
            }

            Console.WriteLine("------");

            #endregion

            #region Task2 - Lab5:
            //2. Int tipinde listiniz var, daxilindeki reqemleri filtrasiya edin
            //{ -1,5,10,32,-10,0,99,43,7,8 }
            //yalniz 10dan boyukleri yazdirin

            List<int> list = new List<int> { -1, 5, 10, 32, -10, 0, 99, 43, 7, 8 };

            foreach (int deyer in list.Where(x => x > 10))
            {
                Console.WriteLine(deyer);
            }

            Console.WriteLine("------");


            #endregion

            #region Task3 - Lab5:
            //3. Luget yaradin, bir nece soz ve tercumesini elave edin(key, value mentiqi)
            //Sonra istifadeciden soz daxil etmeyi xahis edin
            //Eger soz lugetde varsa tercumesini cap edin eks halda muvafiq mesaj cap olunsun

            Dictionary<string, string> Luget = new Dictionary<string, string>();
            Luget.Add("apple", "alma");
            Luget.Add("bear", "heyva");
            Luget.Add("dog", "it");

            Console.Write("Soz daxil edin: ");
            string soz = Console.ReadLine();

            foreach (string deyer in Luget.Keys)
            {
                if (deyer.ToLower() == soz.ToLower())
                {
                    Console.WriteLine(Luget[deyer]);
                }
            }

            Console.WriteLine("-------");

            #endregion

            #region Task4 - Lab5:
            //4. int tipinde listiniz olacaq
            // 2 dene method yaradacaqsiz:
            //PrintList - listi yazdirmaq ucun
            //FilterByDivisor - list ve number qebul edecek. List otureceksiz number'e oturduyunuz deyer
            //filtrasiya ucun lazim olacaq. yalniz verilmis number'e qaliqsiz bolunen reqemler yazdirilacq

            List<int> list2 = new List<int> { -1, 5, 10, 32, -10, 0, 99, 43, 7, 8 };

            //PrintList(list2);
            //Console.WriteLine("_____");
            //FilterByDivisor(list2, 9);

            FilterByDivisor(list2, 5);

            #endregion

        }

        static void PrintList(List<int> list2)
        {
            foreach (int deyer in list2)
            {
                Console.WriteLine(deyer);
            }
        }
        static void FilterByDivisor(List<int> list2, int num)
        {
            //foreach (int deyer in list2)
            //{
            //    if(deyer%num==0)
            //    {
            //        Console.WriteLine(deyer);
            //    }
            //}

            var list = list2.Where(x => x % num == 0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        class Student
        {
            public string Name;
            public double Grade;

            public Student(string name, double grade)
            {
                Name = name;
                Grade = grade;
            }
        }
    }
}
