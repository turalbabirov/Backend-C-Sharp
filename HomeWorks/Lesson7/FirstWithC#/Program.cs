using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using FirstWithC_.Task2;

namespace FirstWithC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Task1 - Lesson 7:
            //İsArrayContains methodu var parametr olaraq iki int arrayi alır
            //və ikinci arrayın birinci arrayin daxilində olub olmadığın qaytarır.
            //Məsələn:
            //arr1 = [2, 3, 4, 7]
            //arr2 = [3, 2, 7]
            //-> false
            //---------------------------
            //arr1 = [2, 3, 4, 7]
            //arr2 = [3, 4]
            //-> true

            //(not nümunələrdən aydın olduğu kimi
            //burda ikinci array sıralaması ilə və bütün ədədləri ilə birlikdə 1ci arrayda olmalıdır,
            //bütün rəqəmləri 1 ci arraydə olsa belə sıralamasına da baxmaq lazımdır)
            int[] arr1 = { 2, 3, 4, 7 }; 
            int[] arr2 = { 3, 4, 7 };

            Console.WriteLine(IsArrayContains(arr1, arr2));
            Console.WriteLine("--------------------");

            #endregion

            #region Task2 - Lesson 7:
            //User və Student classınız var.
            //User classında Name Surname Username Password propertyləri var.
            //Student classında isə yuxarıdakı propertylərdən əlavə Grade propertysi də var.
            //Özünüzdə User arrayi saxlayıb içində bir neçə data saxlayın.
            //App run olanda istifadəçidən username və passvord istəyin.
            //Əgər daxil edilən username və passvorddə olan user vardırsa...
            //və bu user studentdirsə, Grade - i ekrana çap olunsun.
            //<Qeyd!!! hazır metodlardan istifadə etməyin>

            Console.Write("Username daxil edin: ");
            string username = Console.ReadLine();
            Console.Write("Password daxil edin: ");
            string pass = Console.ReadLine();

            Schoolmanagement(username, pass);

            #endregion
        }

        //Task1:
        static bool IsArrayContains(int[] arr1, int[] arr2)
        {
            string esasEded = "";
            string arrEded = "";

            for (int i=0, prevIndeks = 0; i<arr1.Length; i++) 
            {
                for (int j=0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        if( i-1==prevIndeks )
                        {
                            esasEded += $"{arr1[i]}";
                        } else
                        {
                            esasEded = $"{arr1[i]}";
                        }

                        prevIndeks = i;
                        continue;
                    }
                }
            }

            foreach(int num in arr2)
            {
                arrEded += $"{num}";
            }

            if (int.Parse(esasEded) == int.Parse(arrEded)) return true;
            return false;
        }

        //Task2:
        static void Schoolmanagement(string username, string pass)
        {
            var user = dbUsers(username, pass);

            Student st = new Student(
                user.FirstName, 
                user.LastName,
                user.Username,
                user.Password,
                user.Status,
            );

        }

        static object dbUsers(string username, string pass)
        {
            var userInfo = new object();

            UserList[] userList = {
                new UserList { Id = 1, FirstName="Murqubad", LastName="Muellim", Username="mirqubadX", Password="mirq1234", Status="teacher" },
                new UserList { Id = 2, FirstName="Tural", LastName="Babirov", Username="turalbabirov", Password="tb4321", Status="student" },
                new UserList { Id = 3, FirstName="Semed", LastName="Mirzezade", Username="smirzezade", Password="smirze123", Status="student" },
            };

            foreach (var user in userList) //var yerine ne tip olmalidi sorus
            {
                if (user.Username == username && user.Password == pass)
                {
                    //userInfo = user;
                    return user;
                }
            }

            return userInfo;
        }
    }

    class UserList
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Username;
        public string Password;
        public string Status;
    }
}