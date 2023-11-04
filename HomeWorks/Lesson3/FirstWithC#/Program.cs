using System;
//using System.Collections.Generic;
using System.Text;


namespace FirstWithC_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Lesson 3. Dərsdə işlədiyimiz tapşırıq.:

            //NameSurname("Tural", "Babirov");
            //Console.WriteLine(isEven(21));

            #endregion

            #region Lesson 3. Ev tapşırığı - Task1:

            //int ededSadedir = 5;

            //IsPrime(ededSadedir);

            //if (IsPrime(ededSadedir))
            //{
            //    Console.WriteLine($"{ededSadedir} ədədi mürəkkəb ədəddir.");
            //} else
            //{
            //    Console.WriteLine($"{ededSadedir} ədədi sadə ədəddir.");
            //}

            #endregion

            #region Lesson 3. Ev tapşırığı - Task2:

            Console.Write("Riyaziyyat: ");
            int Riyaziyyat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kimya: ");
            int Kimya = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fizika: ");
            int Fizika = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hendese: ");
            int Hendese = Convert.ToInt32(Console.ReadLine());

            int[] qiymetlerSiyahisi = { Riyaziyyat, Kimya, Fizika, Hendese };

            CalcAvg(qiymetlerSiyahisi);

            #endregion
        }

        static void NameSurname(string ad,  string soyad)
        {
            Console.WriteLine($"Ad: {ad}, Soyad: {soyad}");
        }

        static bool isEven(int eded)
        {
            if(eded%2==0)
            {
                return true;
            }

            return false;
        }

        static bool IsPrime(int eded)
        {
            int saygac = 0;

            for (int i=2; i<eded; i++)
            {
                if (eded != 2 && eded % i==0)
                {
                    saygac++;
                    return true; //murekkebdir
                }
            }

            return false; //sadedir
        }

        static bool CalcAvg(int[] qiymetlerSiyahisi)
        {
            int qiymetOrtalamasi = 0;

            foreach(int qiymet in qiymetlerSiyahisi)
            {
                if (qiymet >= 0 && qiymet <= 100)
                {
                    qiymetOrtalamasi += qiymet;
                }
                else
                {
                    Console.WriteLine($"{qiymet} qiyməti yanlışdır. Zəhmət olmasa düzgün qiymət yazın.");
                }
            }

            qiymetOrtalamasi /= qiymetlerSiyahisi.Length;

            if (qiymetOrtalamasi>= 60)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"Ortalamanız {qiymetOrtalamasi}. Məzun oldunuz.");
            } else
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"Ortalamanız {qiymetOrtalamasi}. Məzun ola bilmədiniz.");
            }


            return false; //Yanlış dəyər gələrsə
        }
    }
}
