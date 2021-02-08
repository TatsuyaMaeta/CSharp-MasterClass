using System;

namespace Sec06_property
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box box = new Box();

            //引数に渡すことでまとめることができる
            Box box = new Box(2, 3, 4);

            //プロパティに直接アクセスしない
            //box.length = 3;
            //box.Length = 3;
            ////box.setLength(3);
            //box.Height = 4;
            //box.Width = 5;
            ////box.GetVolume();




            box.DisplayInfo();

            Console.WriteLine("width is {0}", box.Width);
            Console.WriteLine("Volume is {0}",box.GetVolume());

            Console.WriteLine("Length is {0}",box.Height);
            
        }
    }
}

