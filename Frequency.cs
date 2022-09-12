using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Frequency
    {
        static void Main(string[] args)
        {
            String str = "ThinkQuotient";
            char ch = 't';

            int freq = str.Split(ch).Length - 1;
            Console.WriteLine(freq);
        }
    }
}
