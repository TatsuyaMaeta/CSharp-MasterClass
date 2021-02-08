using System;
using System.Diagnostics;

namespace sec06_member_and_destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //コンストラクタについてはもう少し学ぶ必要あり！

            Members member1 = new Members();

            member1.Introducing(true);
            
            Console.Read();
        }
    }
}
