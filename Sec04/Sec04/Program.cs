using System;
using Microsoft.VisualBasic;

namespace Sec04
{
    public class Program {

        static void Main(string[] args)
        {
            string statefMatter = "";
            int temprature = 100;
            string str ="a";

            statefMatter = "liquid";

            statefMatter = temprature >100 && str =="a" ? "gas" :
                temprature < 0 ? "solid":
                "liquid";
            Console.WriteLine($"{statefMatter} / {temprature}");
        }

    }
}
