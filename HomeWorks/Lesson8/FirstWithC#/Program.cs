using Microsoft.VisualBasic.FileIO;
using System;
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

            #region Task1 - Lesson 8.
            //Aşağıdaki metodları olan IAccount interface yaradırsınız:
            //1) PasswordChecker() - parameter olaraq string şifrəni qəbul edir
            //2) ShowInfo()

            //Aşağıdaki memberlərdən ibarət User class-ı yaradırsınız və IAccount-u implement edirsiniz:
            //1) Fullname
            //2) Email
            //3) Password
            //4) PasswordChecker() - PasswordChecker metodu - gələn string şifrə dəyərinin..
            //şərtləri ödəyib ödəmədiyini yoxlayıb true/false dəyər qaytarır.

            //Şərtlər: 
            //*) Şifrədə minimum 8 character olmalıdır 
            //*) Şifrədə ən az 1 böyük hərf olmalıdır 
            //*) Şifrədə ən az 1 kiçik hərf olmalıdır 
            //*) Şifrədə ən az 1 rəqəm olmalıdır
            //*) ShowInfo() - Console-a User-in Fullname və email-inin yazdırır

            //ps: User classına IAccount interface-i implement edilir
            //User yarandığı zaman email ve şifrə təyin edilməsi məcburidir.
            //Userə şifrə təyin edilərkən şifrənin PasswordChecker metodunun şərtlərini ödəməsi lazımdır.
            Console.Write("Emailini yaz: ");
            string email = Console.ReadLine(); //"turalbabirov@mail.com"
            Console.Write("Şifrəni yaz: ");
            string shifre = Console.ReadLine();

            User user = new User(email, shifre);

            #endregion
        }

        public interface IAccount
        {
            public abstract bool PasswordChecker(string pass);
            public abstract void ShowInfo();
        }

        class User : IAccount
        {
            public string Fullname;
            public string Email;

            private string _password;
            public string Password
            {
                get
                {
                    return _password;
                }

                set
                {
                    if (PasswordChecker(value))
                    {
                        _password = value;
                        ShowInfo();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Şifrə təyin olunmadı.");
                    }

                }
            }
            public User(string email, string password)
            {
                Fullname = email == "turalbabirov@mail.com" ? "Tural Babirov" : "Istifadeci";
                Email = email;
                Password = password;
            }
            public bool PasswordChecker(string pass)
            {
                if (pass.Length >= 8)
                {
                    bool kicikHerf = false;
                    bool boyukHerf = false;
                    bool reqem = false;

                    foreach (char letter in pass)
                    {
                        if (Char.IsDigit(letter)) reqem = true;
                        else
                        {
                            if (letter == char.ToLower(letter)) kicikHerf = true;
                            if (letter == char.ToUpper(letter)) boyukHerf = true;
                        }
                    }

                    if (kicikHerf && boyukHerf && reqem) return true;
                }

                return false;
            }

            public void ShowInfo()
            {
                Console.Clear();
                Console.WriteLine($"User fullname: {Fullname}\nUser email: {Email}");
            }
        }
    }
}