using System;
namespace Sec06_property
{
    class Box
    {
        //private int length;
        private int height;
        //public int width;
        private int volume;
        //public int volmue;

        public Box(int length, int height, int width) {
            this.Length = length;
            this.height = height;
            this.Width = width;
        }


        public int Length{ get; set; }

        //propで一発で入力できる
        //heightで書いている内容と同じ
        //return this.widthと
        //this.Width = Valueというのはデフォルトの書き方
        //それゆえに省略してもいいよねという短縮コード
        public int Width{ get; set; }

        //↓のプロパティは,上の1行の書き方と同じ

        //public int Width
        //{
        //    get {
        //        return this.Width;
        //    }
        //    set
        //    {
        //        this.Width = value;
        //    }
        //}

        //プロパティの頭文字はC#では大文字にする
        public int Height {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        //-------------------- いわゆるカプセル化 --------------------
        //プロパティになる変数はpublicにして直接アクセスできない様にしなければならない

       

        //これがいわゆるセッター。メソッドにしてその中でクラスないのプロパティ変数に値を入れる
            //public void setLength(int length)
            //{
            //    this.length = length;
            //}

        //プロパティの値を取得したい場合はリターンでクラス内のスコープの変数を返す
        //値を返すのでintになっている(値の代入はセットなのでvoid)
            //public int GetLength()
            //{
            //    return this.length;
            //}

        //-------------------- いわゆるカプセル化 --------------------

        public int GetVolume() {
            return this.Length * this.Width * this.height;
        }


        public void DisplayInfo() {
            //Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}",
            //        this.Length, this.height, this.Width, this.Volume = this.Length * this.height * this.Width);
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}",
                this.Length, this.height, this.Width, this.Volume );

        }

        public int Volume
        {
            get
            {
                return this.Length * this.Height * this.Width;
            }

            //Volumeは常に値を返すだけなのでセッターは必要ない
            //set
            //{
            //    this.Volume = value;
            //}
        }

    }
}
