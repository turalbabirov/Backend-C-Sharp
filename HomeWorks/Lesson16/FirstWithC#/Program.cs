using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstWithC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //PrintText adlı metodunuz olsun.
            //Parametr olaraq string dəyər alsın və aldığı dəyəri console - a videodakı kimi çıxartsın

            Thread thread1 = new Thread(PrintText);
            thread1.Start();

        }

        static void PrintText()
        {
            string ad = "Tural";

            foreach(char herf in ad)
            {
                Console.Write(herf);
                Thread.Sleep(1000);
            }
        }
    }
}