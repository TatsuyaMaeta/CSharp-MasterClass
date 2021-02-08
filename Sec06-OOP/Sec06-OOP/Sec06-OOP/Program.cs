using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Sec06_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //コンストラクタに引数を与えることで、それを引き渡し先で変数に入れて処理できる
            Human Denis = new Human("Denis", "Wagner","black",30);

            //Denis.firstName = "Denis";
            //Denis.familyName = "Wagner";
            Denis.IntroduceMyself();


            //int thousand, hundred, ten, one;
            int max = 10;
            string stringRight;
            string stringLeft;
            bool isGet = false;
            double check_left,check_right;
            double right_bunshi, right_bunbo, left_bunshi, left_bunbo;
            int count=0;
            string str = "";

            for (int thousand = 0; thousand < max; thousand++)
            {
                for (int hundred = 0; hundred < max; hundred++)
                {
                    for (int ten = 0; ten < max; ten++)
                    {
                        for (int one = 0; one < max; one++)
                        {
                            for (int i = 0; i < max; i++)
                            {
                                for (int ii = 0; ii < max; ii++)
                                {
                                    for (int iii = 0; iii < max; iii++)
                                    {
                                        for (int iiii = 0; iiii < max;iiii++)
                                        {
                                            if (i + ii + iii + iiii == 0)
                                            {
                                                iiii = 1;
                                            }

                                            if (i * ii * iii * iiii > 0)
                                            {
                                                left_bunshi = (double)(thousand * hundred * ten * one);
                                                left_bunbo = (double)(i * ii * iii * iiii);

                                                right_bunshi = (double)(thousand + hundred + ten + one);
                                                right_bunbo = (double)(i + ii + iii + iiii);

                                                check_left = left_bunshi / left_bunbo;
                                                check_right = right_bunshi / right_bunbo;

                                                if (check_left == check_right && (check_left != 0 && check_right != 0)) 
                                                {
                                                    stringLeft = thousand.ToString() + hundred.ToString() + ten.ToString() + one.ToString();
                                                    stringRight = i.ToString() + ii.ToString() + iii.ToString() + iiii.ToString();

                                                    if (stringRight =="6000")
                                                    {
                                                        Console.WriteLine(6000);
                                                    }

                                                    if (stringRight != stringLeft && thousand==1 && hundred == 3 && i== 1)
                                                    {
                                                        Console.WriteLine("{0} {1} {2} {3}  // {4} {5} {6} {7}", thousand, hundred, ten, one, i, ii, iii, iiii);
                                                        isGet = true;
                                                        count ++;
                                                    }


                                                }
                                            }

                                        }

                                    }
                                }
                            }
                        }

                    }
                }
            }

            if (isGet != true)
            {
                Console.WriteLine("non number");
                Console.ReadLine();
            }
            else
            {
               str = Console.ReadLine();
            }
        }
    }
}
