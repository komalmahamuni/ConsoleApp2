using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program7
    {
        static bool IsPalindrome(string s)
        {
            bool palindrome = true;
            for (int i = 0; i < s.Length / 2 + 1; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }


        static void Main(string[] args)
        {
            Console.Write("ENTER A STRING :- ");
            string s = Console.ReadLine();
            if (IsPalindrome(s) == true)
            {
                Console.WriteLine(s + " IS A PALINDROME");
            }
            else
            {
                Console.WriteLine(s + " IS NOT A PALINDROME");
            }

        }
    }
}
