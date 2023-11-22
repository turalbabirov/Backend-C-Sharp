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

            //Human class:
            //Name, Surname, Age  Name dəyəri təyin olunmamış Human yaradıla bilməsin

            //Student class:
            //Human-dan miras alır. Əlavə olaraq Grade xüsusiyyəti var.
            //Grade dəyəri təyin olunmamış Student yaradıla bilməsin

            //Employe class:
            //Human-dan miras alır. Əlavə olaraq Position xüsusiyyəti  var.
            //Position təyin olunmamış Employe yaradıla bilməsin.
            //-------------------------------------------------------------

            //Employe ve Student listi yaradırsız.

            //Proqram işə düşdükdə:
            //1-Student əlavə et
            //2-Employe əlavə et
            //3-Axtarış et
            //4-Çıxış Menusu gəlsin.

            //Əgər 1 seçilsə: yeni bir student elave olunsun listə
            //Əgər 2 seçilsə:  yeni employee əlavə olunsun listə
            //Əgər 3 seçilsə: Menu açılsın
            //--1-Employe üzrə axtarış
            //--2-Student üzrə axtarış
            //**Əgər 1 seçilsə Position daxil edilməsini istəsin
            //ve uyğun positionda olan Employelerin Adlarını konsola yazdırsın
            //**Əgər 2 seçilsə minGrade ve maxGrade dəyərləri daxil etməyimizi istəsin
            //ve həmin aralıqda grade-si olan studentlərin Name və Grade dəyərlərini
            //konsola yazdırsın
            //Əgər 4 seçilsə Proqram sonlansın.
            //(4 seçilmədiyi müddətcə Hər dəfə menu qarşımıza çıxsın.)


            //Taskla bağlı Bilmədiyiniz nəsə olsa araşdırma edin mütləq.
            //Ümumiyyətlə axtarış edib tapma inkişaf üçün çox önəmlidir

            //Artıq qeyd filan olmayacaq Hazır Metodlardan istifadə edin getsin 😁
        }
    }
}