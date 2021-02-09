using System;
using System.Diagnostics;

namespace sec06_member_and_destructor
{
    public class Members
    {
        private string menmerName;
        private string jobTitle;
        private int age;
        private int salary;

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public int Age { get; set; }

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.",
                    menmerName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My Salary is {0}", this.salary);

        }

        //member constractor
        public Members(){
            age = 30;
            menmerName = "joe";
            salary = 600000;
            jobTitle = "developer";
            Console.WriteLine("");
        }

        //デストラクタ(ファイナライザ)は各クラスごとで1つだけ
        //デストラクタは一番下に書く
        ~Members(){
            //cleanup statement
            Console.WriteLine("Deconstraction of Members object");
            Debug.Write("Deconstraction of Members object");
        }
    }
}
