using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Sec07_arrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var numbers = new List<int>();

            numbers.Add(24);
            numbers.Add(50);
            numbers.RemoveAt(1);
            numbers.Clear();

            var scores = new int[] { 99, 84, 76, 59, 72 };

            List<int> nums = new List<int> { 11, 23, 41, 25, 3, 29 };

            foreach (var i in scores)
            {
                Console.WriteLine(i);
            }

            nums.RemoveRange(2, 2);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            ArrayList arrList = new ArrayList();

            arrList.Add(1);
            arrList.Add("two");
            arrList.Add("3");
            arrList.Add(new Number { n = 4 });

            foreach (var obj in arrList)
            {
                Console.WriteLine(obj);
            }
        }
    }
    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
