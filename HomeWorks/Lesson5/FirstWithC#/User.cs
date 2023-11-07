using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FirstWithC_
{
    internal class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name;
        public string Password;
        public bool IsPasswordValid()
        {
            bool type = false;

            if(Password.Length<6)
            {
                return type; //sifre 6-dan azsa false
            } else
            {
                foreach (char character in Password)
                {
                    int number;
                    if (int.TryParse(character.ToString(), out number))
                    {
                        type = true; //eger icinde reqem varsa true 
                    }
                }


                string[] parts = Regex.Split(Password, @"(?<=\d)");
                foreach (string part in parts)
                {
                    if (part==Name.ToLower())
                    {
                        type = false; //eger icinde Name varsa false 
                    }
                }
        }

            return type;
        }
    }
}
