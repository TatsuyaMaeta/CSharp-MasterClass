using System;

namespace Sec05
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 15;

            string str = string.Empty;
            
            for (int ii = 0; ii < max; ii++)
            {
                for (int i = 0; i < max; i++)
                {
                    Console.WriteLine("i : {0}",i);
                    Console.WriteLine("ii : {0}", ii);
                    if (i.Equals(4) && ii.Equals(5))
                    {
                        Console.WriteLine("i : {0} /  ii : {1}", i,ii);
                        Console.WriteLine("counter is stop");
                        break;
                    }

                    Console.WriteLine(ii);

                    //if (i == 4)
                    //{
                    //    Console.WriteLine("counter is stop");
                    //    break;
                    //}
                }
            }
        }
    }
}
