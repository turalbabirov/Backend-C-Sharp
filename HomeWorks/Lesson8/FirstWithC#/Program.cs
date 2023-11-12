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
            User user = new User() {
                Fullname = "Tural Babirov",
                Email = "turalbabirov@mail.com",
                Password = "Tbabirov1"
            };
            user.ShowInfo();
            Console.WriteLine("------------");

            string deyer = user.PasswordChecker() ? "Uğurlu şifrə" : "Yanlış şifrə";
            Console.WriteLine(deyer);

            #endregion
        }

        public interface IAccount
        {
            public abstract bool PasswordChecker();
            public abstract void ShowInfo();
        }

        class User: IAccount
        {
            public string Fullname;
            public string Email;
            public string Password;

            public bool PasswordChecker()
            {
                if(Password.Length>=8) {
                    bool kicikHerf = false;
                    bool boyukHerf = false;
                    bool reqem = false;

                    foreach (char letter in Password)
                    {
                        if (Char.IsDigit(letter)) reqem = true;
                        else
                        {
                            if (letter == char.ToLower(letter)) kicikHerf = true;
                            if (letter == char.ToUpper(letter)) boyukHerf = true;
                        }
                    }

                    //Console.WriteLine(boyukHerf);

                    if (kicikHerf && boyukHerf && reqem) return true;
                }

                return false;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"User fullname: {Fullname}\nUser email: {Email}");
            }
        }
    }
}