using System;

namespace Sec03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                //０では割れない
                Console.WriteLine("can't divide by zero");
            }



            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                //文字列が入ってきた場合はこちら（フォーマットエラー）
                Console.WriteLine("Format exeption, please the correct type next time.");
            }
            catch (OverflowException)
            {
                //範囲外の整数の場合はこちら　（オーバーフロー）
                Console.WriteLine("General Exception");
            }
            catch (ArgumentNullException)
            {
                //入力値がない場合はこちら　（null）
                Console.WriteLine("General Exception");
            }
            finally
            {
                //ネット接続や、ファイル書き込み時のエラーなどの場合
                Console.WriteLine("this is anyways");
            }


        }
    }
}
