using System;

namespace FirstWithC_
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    //// 2 eded verilib a ve b bu iki eded araligindaki ededlerin cemi
        //    //int a1 = 1;
        //    //int a2 = 5;
        //    //int cem = 0;

        //    //for (int i = a1; i < a2; i++)
        //    //{
        //    //    cem += i;
        //    //}

        //    //Console.WriteLine(cem);


        //    // i=1-den baslayaraq a-ya qeder 15-e bolunen ededlerin sayini tapmaq
        //    int ededlerinSayi = 0;
        //    int a = 200;

        //    for (int i = 1; i < a; i++)
        //    {
        //        if (i % 15 == 0)
        //        {
        //            ededlerinSayi++;
        //        }
        //    }

        //    Console.WriteLine(ededlerinSayi);

        //}

        //static void Main(string[] args)
        //{
        //    int a;
        //    double b;
        //    double max = 0;
        //    Console.WriteLine("Eded daxil edin : \t");
        //    a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Eded daxil edin : \t");
        //    b = double.Parse(Console.ReadLine());
        //    max = a;

        //    if( max<b ) { 
        //        max = b; 
        //    }

        //    Console.WriteLine(max);
        //}



        //static void Main(string[] args)
        //{

        //    // 1-dən M-ədək ədədlər içərisində 21-ə bölünən ədədlərin ədədi ortasını tapan alqoritm:
        //    int M = 200;
        //    int saygac = 0;
        //    int cem = 0;

        //    for (int i = 1; i < M; i++)
        //    {
        //        if (i % 21 == 0)
        //        {
        //            saygac++;
        //            cem += i;
        //        }
        //    }

        //    Console.WriteLine(cem / saygac);

        //}


        static void Main(string[] args)
        {

            //2 ədəd verilmişdir. Daxil Edilən Ədədlərdə Daxil Olmaqla
            //Bu Ədədlərin Aralığında Olan Ədədlərin cəmin Tapan Alqoritm Qurun.
            int eded1 = 4;
            int eded2 = 5;
            int cem = 0;

            for( int i=eded1; i<=eded2; i++ )
            {
                cem += i;
            }

            Console.WriteLine(cem);

        }


    }
}