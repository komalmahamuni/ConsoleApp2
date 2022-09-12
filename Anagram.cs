using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Anagram
    {
        static void Main(string[] args)
        {
            String s1 = "Race";
            String s2 = "Care";
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();

            Array.Sort(a1);
            Array.Sort(a2);

            if (Array.Equals(a1, a2))
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not");
        }
    }
}
