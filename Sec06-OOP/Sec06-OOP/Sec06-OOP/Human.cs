using System;
namespace Sec06_OOP
{
    class Human
    {

        private string firstName_global;
        private string lastName_global;
        private string eyeColor_global;
        private int age;

        public Human(string myFirstName, string lastName,string eyeColor,int age) {
            //firstName_global = myFirstName;
            this.firstName_global = myFirstName;

            //このクラス内にある変数のことを指す。thisの方が明示的で分かりやすい
            this.lastName_global = lastName;

            this.eyeColor_global = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself() {

            Console.WriteLine("Hi, I'm {0} {1}", firstName_global, lastName_global);
            Console.WriteLine("eye color is {0}, age is {1}", eyeColor_global, age);
        }
    }
}
