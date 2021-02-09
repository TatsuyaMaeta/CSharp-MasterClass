using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace TicTacToe
{
    class Program
    {
        static char[,] playerField =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            

            do
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if(player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                SetField();

                #region
                //勝敗の確認
                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playerField[0, 0] == playerChar) && (playerField[0, 1] == playerChar) && (playerField[0, 2] == playerChar))
                        || ((playerField[1, 0] == playerChar) && (playerField[1, 1] == playerChar) && (playerField[1, 2] == playerChar))
                        || ((playerField[2, 0] == playerChar) && (playerField[2, 1] == playerChar) && (playerField[2, 2] == playerChar))
                        || ((playerField[0, 0] == playerChar) && (playerField[1, 0] == playerChar) && (playerField[2, 0] == playerChar))
                        || ((playerField[0, 1] == playerChar) && (playerField[1, 1] == playerChar) && (playerField[2, 1] == playerChar))
                        || ((playerField[0, 2] == playerChar) && (playerField[1, 2] == playerChar) && (playerField[2, 2] == playerChar))
                        || ((playerField[0, 0] == playerChar) && (playerField[1, 1] == playerChar) && (playerField[2, 2] == playerChar))
                        || ((playerField[2, 0] == playerChar) && (playerField[1, 1] == playerChar) && (playerField[0, 2] == playerChar)))
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("Player 2 Win");
                        }
                        else
                        {
                            Console.WriteLine("Player 1 Win");
                        }

                        Console.WriteLine("何かキーを押してリセットしてください");
                        Console.ReadKey();

                        ResetField();
                        break;

                    }
                    //もし引き分けの場合
                    else if(turns == 10)
                    {
                        Console.WriteLine("\n引き分けです");
                        Console.WriteLine("\n何かキーを押してリセットしてください");
                        Console.ReadKey();

                        ResetField();
                    }
                }
                #endregion



                #region
                do
                {
                    Console.WriteLine("\nPlayer {0}: フィールドを選んでください",player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("数字を入力してください");
                    }

                    if ((input == 1) && (playerField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playerField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playerField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playerField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playerField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playerField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playerField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playerField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playerField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n 他の数字を入力してください");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion

            } while (true);
        }



        public static void ResetField()
        {
            char[,] playerFieldInitial =
            {
                        {'1','2','3' },
                        {'4','5','6' },
                        {'7','8','9' }
            };
            playerField = playerFieldInitial;

            SetField();

            //ターンをリセット
            turns = 0;
        }

        public static void SetField()
        {
            //後で引数に変数を入れること!
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ",playerField[0,0], playerField[0, 1], playerField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playerField[1, 0], playerField[1, 1], playerField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playerField[2, 0], playerField[2, 1], playerField[2, 2]);
            Console.WriteLine("     |     |     ");

            turns++;
        }


        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 1: playerField[0, 0] = playerSign; break;
                case 2: playerField[0, 1] = playerSign; break;
                case 3: playerField[0, 2] = playerSign; break;
                case 4: playerField[1, 0] = playerSign; break;
                case 5: playerField[1, 1] = playerSign; break;
                case 6: playerField[1, 2] = playerSign; break;
                case 7: playerField[2, 0] = playerSign; break;
                case 8: playerField[2, 1] = playerSign; break;
                case 9: playerField[2, 2] = playerSign; break;
            }
        }
    }
}
