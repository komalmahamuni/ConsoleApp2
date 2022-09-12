using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program10
    {
        static void Main(string[] args)
        {
            string line = "ThinkQuotient software private limited.";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
        }
    }
}
