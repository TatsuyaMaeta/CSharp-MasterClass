

using System;

namespace Sec01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("HELLO");
            //Console.Write("WORLD");

            Console.Write("Enter a string here: ");
            string name = Console.ReadLine();

            Console.Write("Enter the character to search: ");
            int number = int.Parse( Console.ReadLine());

            Console.WriteLine("name substring {0} {1} / {2}", name, number, name.Substring(number));


            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);

            Console.WriteLine("your full name is {0}.",fullName);
            //Console.WriteLine($"your name is {name.ToUpper()}.");
        }
    }
}


