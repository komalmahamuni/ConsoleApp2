﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Prorigo
{
    class AnagramDemo
    {
        public static bool Check(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                string s1 = str1.ToLower();
                string s2 = str2.ToLower();
                char[] ch1 = s1.ToCharArray();
                char[] ch2 = s2.ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                string st1 = new string(ch1);
                string st2 = new string(ch2);
                if (st1 == st2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        



            static void Main(string[] args)
            {
                Console.WriteLine("Enter 1 st string");
                string str1 = Console.ReadLine();
                Console.WriteLine("Enter 2 nd string");
                string str2 = Console.ReadLine();

                bool isAnnagram = AnagramDemo.Check(str1, str2);
                if (isAnnagram == true)
                {
                    Console.WriteLine("string is Annagram");
                }
                else
                {
                    Console.WriteLine("Not Annagram");


            }
            }
        }
    }
}
