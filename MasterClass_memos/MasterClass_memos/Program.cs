using System;

namespace MasterClass_memos {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Sec06 オブジェクト指向-----------------------------");
            // オブジェクト指向に関するおすすめの記事リンク
            // アクセス修飾子
            // https: //code-maze.com/csharp-basics-access-modifiers/

            //作ったクラスは引数の数が重複していなければ同じ名前で作ることができる
            //後ろ引数の数と並びで判断している

            Console.WriteLine ("-----------------------------");

            Console.WriteLine ("-----------------------------");
            //三項演算子の使い方

            string statefMatter = "";
            int temprature = 100;
            string str = "a";

            statefMatter = "liquid";

            statefMatter = temprature > 100 && str == "a" ? "gas" : temprature < 0 ? "solid" : "liquid";
            Console.WriteLine ($"{statefMatter} / {temprature}");
            Console.WriteLine ("-----------------------------");

            //もし波線エラーが出ている場合はoption + Enterでクリックした内容のリストが表示される

            // Not use UserCtr , use UserControl
            //基本的にスネークラインは使用しない

            // 参考サイト
            // https: //www.dofactory.com/net/design-patterns

            // boolの書き方
            bool sunIsShining = false;

            Console.WriteLine (sunIsShining);
            Console.ReadLine ();
        }
    }
}