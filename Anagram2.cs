using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Anagram2
    {
        static void Main(string[] args)
        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine(" Anagrams");
            }
            else
            {
                Console.WriteLine(" not Anagrams");
            }
        }
    }
    }

