using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
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

            //Custom Arraylist classı yazın,
            //*Capacity, Count propları olsun,
            //*Capacity qəbul edən constructoru olsun
            //*Add metodu, Remove metodu, RemoveAt metodu, TrimToSize metodu, AddRange metodu olsun

            //QEYD:
            //Add Metodunu indiyə qədər neçə dəfə yazmışıq əslində.
            //RemoveAt - da həmçinin sinifdə yazmışdıq.
            //Digərlərini - də araşdırıb düşünün və yazın.
            //Labdakı taskı tamamlamayanlar yazmağa çalışsın
            //Olmasa bunu həll edin əsas.

            //!! Listin öz metodlarından istifadə etməyin !!

            Arraylist arrList = new Arraylist();
            arrList.Add();

        }
    }

    class Arraylist
    {

        public int Capacity;
        public int Count;

        public void Add()
        {

        }

        public void Remove()
        {

        }

        public void RemoveAt()
        {

        }

        public void TrimToSize()
        {

        }

        public void AddRange()
        {

        }
    }
}