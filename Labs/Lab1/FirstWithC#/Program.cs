using System;
using System.Text;

namespace FirstWithC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Lab1 - Ruslan.:
            //1. Daxil edilen ededin cut ve ya tek olmasinin alqoritmasini qurun
            int eded1 = 20;
            string ededNedir = eded1 % 2 == 0 ? "cutdur" : "tekdir";
            Console.WriteLine(ededNedir);
            Console.WriteLine("------------");


            //2. Vurma cedveli: Bir eded daxil edilir ve 10-a qeder vurma cedvelini qaytaran alqoritma qurun.
            int eded2 = 1;
            string result2 = "";
            for (int i = 0; i < 10; i++)
            {
                result2 += $"{eded2}x{i}=" + eded2 * i + "\n";

            }

            Console.WriteLine(result2);
            Console.WriteLine("------------");


            //3. Daxil edilen eded uzre(eded ilin aylaridir) ilin hansi feslidir teyin eden alqoritm qurun.
            int ay = 3;

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Qis fesli");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Yaz fesli");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yay fesli");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Payiz fesli");
                    break;
            }
            Console.WriteLine("------------");


            //4.Daxil edilen ededin reqemlerinin hasilini hesablayan alqoritim
            int eded3 = 213;
            int result = 1;

            while (eded3 > 1)
            {
                int digit = eded3 % 10;
                result *= digit;
                eded3 /= 10;
            }

            Console.WriteLine(result);
            Console.WriteLine("------------");



            //5. Supermarketde aksiya kecirilir: 3 mehsul aldiqda, en ucuz mehsul pulsuz olur.
            //(Mes, 40, 50, 20 = 90). 3 mehsulun qiymeti verildikde musterinin ne qeder odemeli oldugunu
            //tapan alqoritma qurun.
            double mehsul1 = 30;
            double mehsul2 = 21.99d;
            double mehsul3 = 50;

            if (mehsul1 != 0 && mehsul2 != 0 && mehsul3 != 0)
            {
                double pulsuzMehsul = mehsul1 < mehsul2 && mehsul1 < mehsul3 ? mehsul1 : mehsul2 < mehsul3 ? mehsul2 : mehsul3;
                double odemeliPul = (mehsul1 + mehsul2) - pulsuzMehsul;
                Console.WriteLine(odemeliPul);
            }
            Console.WriteLine("------------");


            //Bonus. Qiymetlendirme sistemi yaratmalisiz:
            //Bize bir bal(reqem olaraq) gelir. Onun hansi qiymet(herf olaraq) oldugunu bildirmelisiz. 
            //Mes: Gelen bal 100(int grade=100 Cavab A); gelen bal 30(int grade=30 Cavab F)
            //Qiymetlendirme araligi: [91-100 > A], [81-90 > B], [71-80 > C], [61-70 > D], [51-60 > E], [0-50 > F]
            //Gelen eded bu araliqda deyilse onu da dusunun ve yanlis eded oldugu bir cavab qaytarin ekrana.

            int balYoxla = 76;
            string netice = "";

            switch (balYoxla)
            {
                case (> 90 and <= 100):
                    netice = $"Gelen bal:{balYoxla}, Cavab: A";
                    break;
                case (> 80 and <= 90):
                    netice = $"Gelen bal:{balYoxla}, Cavab: B";
                    break;
                case (> 70 and <= 80):
                    netice = $"Gelen bal:{balYoxla}, Cavab: C";
                    break;
                case (> 60 and <= 70):
                    netice = $"Gelen bal:{balYoxla}, Cavab: D";
                    break;
                case (> 50 and <= 60):
                    netice = $"Gelen bal:{balYoxla}, Cavab: E";
                    break;
                case (> 0 and <= 50):
                    netice = $"Gelen bal:{balYoxla}, Cavab: F";
                    break;
                default:
                    netice += $"Bele cavab yoxdur. Xahis olunur {balYoxla} deyil, [0-100] reqemi daxil edin.";
                    break;
            }

            Console.WriteLine(netice);

            #endregion
        }
    }
}
