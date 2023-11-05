using Microsoft.VisualBasic.FileIO;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;

namespace FirstWithC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Task1 - Lab2.:
            //1. Verilmiş ədədin rəqəmləri cəmini tapıb qaytaran  metod:
            int verilenEded = 1234;
            int ededlerinCcemi = 0;

            while (verilenEded != 0)
            {
                int digit = verilenEded % 10;
                ededlerinCcemi += digit;
                verilenEded = verilenEded / 10;
            }

            Console.WriteLine(ededlerinCcemi);
            Console.WriteLine("------------");

            #endregion

            #region Task2 - Lab2.:
            //2. Verilmiş interger arrayində verilmiş integer ədədinin yerləşdiyi ilk indexi tapıb qaytaran metod.
            //Əgər tapmasa -1 qaytarsın.
            //(Metodu işlətdikdə içinə arqument olaraq bir integer array və bir ədəd göndərilir)
            int[] arr = { 122, 33, 43, 21, 24, 10 };

            Console.WriteLine( FirstIndex(arr, 33) );
            Console.WriteLine("------------");

            #endregion

            #region Task3 - Lab2.:
            //3. Verilmiş string tipindən array də ən uzununu qaytaran metod
            //+ LargestNum(method overloading edeceksiniz)
            string[] strArr = { "bmw", "renault", "hundai" };
            int[] intArr = { 100, 120, 174, 165, 144 };

            Console.WriteLine(LargestElement(strArr));
            Console.WriteLine(LargestElement(intArr));
            Console.WriteLine("------------");

            #endregion

            #region Task4 - Lab2.:
            //4. Verilmis ededler siyahisindaki cut ededlerden ibaret yeni bir array qaytaran method.
            // Misalcun gonderilmis ededler siyahisinda {1,3,4,5,6} deyerleri varsa method
            // geriye {4,6} deyerlerinden ibaret bir array qaytarmalidir

            int[] ededler = { 3, 7, 2, 9, 14, 20, 29 };

            //Console.WriteLine(cutQaytar(ededler));
            foreach(int el in cutQaytar(ededler))
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("------------");

            #endregion

            #region Task5 - Lab2.:
            //5.
            // a)Layihe ise dusdukde sizden adlarin sayini istesin.
            // b)Daha sonra o say qeder adlari daxil edin.
            // c)Daha sonra axtardiginiz adi istesin,
            // onu da daxil etdikden sonra siyahida olub olmadigini qaytarsin
            Console.Write("Neçə dənə ad istəyirsən? ");
            int eded = int.Parse(Console.ReadLine());

            Console.WriteLine(AdiTap(eded));

            #endregion
        }

        //Task2:
        static int FirstIndex(int[] qiymetlerSiyahisi, int eded)
        {
            
            int indeks = 0;

            foreach(int i in qiymetlerSiyahisi)
            {
                if(i == eded)
                {
                    return indeks;
                }
                
                indeks++;
            }

            return -1;
        }

        //Task3:
        static string LargestElement(params string[] strings)
        {
            int enBoyuk = 0;
            string enBoyukStr = "";

            foreach(string str in strings)
            {
                if(str.Length > enBoyuk)
                {
                    enBoyuk = str.Length;
                }

                if(str.Length == enBoyuk)
                {
                    enBoyukStr = str;
                }
            }

            return enBoyukStr;
        }
        static int LargestElement(params int[] nums)
        {
            int enBoyuk = 0;

            foreach(int eded in nums)
            {
                if(eded > enBoyuk)
                {
                    enBoyuk = eded;
                }
            }

            return enBoyuk;
        }

        //Task4:
        static int[] cutQaytar(int[] ededler)
        {
            int arrayUzunlugu = 0;
            foreach (int eded in ededler)
            {
                if(eded%2==0 && eded!=2)
                {
                    arrayUzunlugu++;
                }
            }

            int[] yeniArr = new int[arrayUzunlugu];

            for (int i = 0, j = 0; i<ededler.Length; i++)
            {
                if (ededler[i] % 2 == 0 && ededler[i] != 2)
                {
                    yeniArr[j] = ededler[i];
                    j++;
                }
            }

            return yeniArr;
        }
        
        //Task5:
        static string AdiTap(int adSayi)
        {
            string[] adlar = new string[adSayi];
            for (int i = 0; i < adSayi; i++)
            {
                Console.Write($"{i + 1}. ad >> ");
                adlar[i] = Console.ReadLine();
            };

            Console.Write("Axtardığınız adı daxil edin: ");
            string axtarilanAd = Console.ReadLine();
            Console.WriteLine("______");

            foreach (string ad in adlar)
            {
                if (ad.ToLower() == axtarilanAd.ToLower())
                {
                    return $"{ad} adında adam bazada var.";
                }
            }

            return $"Bu adda adam bazada yoxdur.";
        }
    }
}
