using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;

namespace FirstWithC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Task1 - Lab3.

            Console.Write("Ədəd1 daxil edin: ");
            string a = Console.ReadLine();
            double eded1 = 0;
            bool result1 = double.TryParse(a, out eded1);

            Console.Write("Operator daxil edin: ");
            string operatorIsaresi = Console.ReadLine();

            Console.Write("Ədəd2 daxil edin: ");
            string b = Console.ReadLine();
            double eded2 = 0;
            bool result2 = double.TryParse(b, out eded2);


            if (!result1 || !result2) Console.WriteLine("Duzgun eded daxil edin");
            else
            {
                switch (operatorIsaresi)
                {
                    case "+":
                        Console.WriteLine(int.Parse(a) + int.Parse(b));
                        break;
                    case "-":
                        Console.WriteLine(int.Parse(a) - int.Parse(b));
                        break;
                    case "*":
                        Console.WriteLine(int.Parse(a) * int.Parse(b));
                        break;
                    case "/":
                        if (b == "0")
                        {
                            Console.WriteLine("Eded 0-a bolune bilmez");
                        }
                        else
                        {
                            Console.WriteLine(int.Parse(a) / int.Parse(b));
                        };

                        break;
                    default:
                        Console.WriteLine("Zehmet olmasa duzgun operator daxil edin");
                        break;
                }
            }


            #endregion
        }

    }
}