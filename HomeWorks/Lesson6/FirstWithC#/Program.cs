using Microsoft.VisualBasic.FileIO;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace FirstWithC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Task1 - Lesson 6:
            //Student classınız olsun. int[] Grades propertysi olsun.
            //Studentdən obyekt yaradıb grades-i set edəndə..
            //..arrayin yalnız cüt ədədlərindən ibarət yeni bir array set olunsun.

            //Yəni, əgər mən:
            //Student st = new Student();
            //st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 } yazıramsa
            //st.Grades { 2,4,6,8 }-ə bərabər olsun

            Student obyekt = new Student();
            obyekt.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            obyekt.GradeShow();


            #endregion
        }
    }
}