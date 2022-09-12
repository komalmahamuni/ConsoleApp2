using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program4
    {
        static void Main(string[] args)
        {

            string s1 = " abc";
            string s2 = " xyz ";
            string s3 = "lmn ";
            Console.WriteLine("Before:");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.WriteLine("");

            
            Console.WriteLine("After:");
            Console.WriteLine(s1.Trim());
            Console.WriteLine(s2.Trim());
            Console.WriteLine(s3.Trim());
        }
    }
}
    

