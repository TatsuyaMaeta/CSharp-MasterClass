using System;

namespace Sec09_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("thanks for the birthday wishes.", true, "Denis");
            Console.WriteLine(post1.ToString());
            //Console.ReadKey();

            ImagePost imagepost1 = new ImagePost("check out my new shoes", "Tatsuya",
                                                    "http://image.com", true);

            Console.WriteLine(imagepost1.ToString());
            Console.ReadKey();
        }
    }
}
