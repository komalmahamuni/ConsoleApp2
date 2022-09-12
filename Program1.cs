using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program1
    {
        static void Main(string[] args)
        {
            string str = "pink rose pink ball";
            string s1 = str.Replace("pink", "white");
            Console.WriteLine(str);
            Console.WriteLine(s1);
        }
    }
}
