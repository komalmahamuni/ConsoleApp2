using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {

          String str;
            int l = 0;

            Console.WriteLine("\n\nprint indivisual characters of string in reverse order :\n");
            Console.Write("--------------------\n");
            Console.Write("Input the String:");
            str = Console.ReadLine();

            l = str.Length - 1;
            Console.Write("The characters of the string in reverse are:\n");
            while(l>=0)
            {
                Console.Write("{0}", str[l]);
                l--;

            }
            Console.Write("\n\n");

        }
    }
}
