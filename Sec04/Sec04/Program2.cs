using System;
namespace Sec04
{
    public class Program2
    {

            //グローバルスコープに存在する変数
            //各メソッドからこの変数に値を入れたり削除したりして操作する
            static string userName = "";
            static string password = "";

            static void Mainsw3(string[] args)
            {
                Register();
                Login();
                Console.Read();
            }

            public static void Register()
            {
                Console.WriteLine("Please enter your username.");
                userName = Console.ReadLine();

                Console.WriteLine("Please enter your password");
                password = Console.ReadLine();
                Console.WriteLine("登録完了しました");
                Console.WriteLine("-------------------------------");

            }

            public static void Login()
            {

                Console.WriteLine("Please enter your username.");
                if (userName == Console.ReadLine())
                {
                    Console.WriteLine("Please enter your password");
                    if (password == Console.ReadLine())
                    {
                        Console.WriteLine("Successful!");
                    }
                    else
                    {
                        Console.WriteLine("Login failed. wrong password");
                    }

                }
                else
                {
                    Console.WriteLine("Login failed. wrong username");
                }

            }

            static void Mainss(string[] args)
            {
                Console.WriteLine("Please enter user name. :");
                bool isAdmin = false;
                bool isResistered = true;
                string userName = "";
                userName = Console.ReadLine();



                if (isResistered)
                {
                    Console.WriteLine("Hi there, registered user");

                    if (userName != "")
                    {
                        if (userName.Equals("Admin"))
                        {
                            Console.WriteLine("Hi there, Admin.");
                        }
                    }

                }



                Console.Read();


            }


            static void Mains(string[] args)
            {

                //int.TryParse()の戻り値はboolean
                Console.WriteLine("What's the temprature like!?");


                string temprature = Console.ReadLine();
                int number;
                int numTemp;
                bool userEnteredANumber = int.TryParse(temprature, out number);

                if (userEnteredANumber)
                {
                    numTemp = number;

                }
                else
                {
                    numTemp = 0;
                    Console.WriteLine("Value entered was no number. 0 set as temprature.");
                }

            }

    }
}
