using System;
//using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace FirstWithC_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine( reverseName("Suleyman", "Semed", "Tural", "Mirqubad") );
        }

        static string reverseName(params string[] adlar)
        {
            string total = "";

            for (int i = 0; i < adlar.Length; i++)
            {
                for(int j=adlar[i].Length-1; j>=0; j--)
                {
                    total += adlar[i][j];
                }
                total += " ";
            }

            return total;
        }
    }
}
