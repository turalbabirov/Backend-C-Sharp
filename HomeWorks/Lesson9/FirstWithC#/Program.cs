using Microsoft.VisualBasic.FileIO;
using System;
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

            #region Task1 - Lesson 9.
            //Task çox bəsittir. Main metodunda aşağıdakı kodu run edəndə 10 cavabı cap olunsun:

            int[] arr = new int[0];
            arr = arr.Add(1);
            arr = arr.Add(2);
            arr = arr.Add(3);
            arr = arr.Add(4);
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);


            #endregion
        }
    }

    static class Extension
    {
        public static int[] Add(this int[] arr, int number)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = number;
            return arr;
        }
    }
}