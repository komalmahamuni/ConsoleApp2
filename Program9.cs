using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program9
    {  
        public static int Character(string s,char c)
        {
            int n = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(c==s[i])
                {
                    n++;
                }
            }
            return n;

        }

   static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Character:");
            char c = char.Parse(Console.ReadLine());
            int a = Character(s, c);
            Console.WriteLine(a);


        }
    }
}
