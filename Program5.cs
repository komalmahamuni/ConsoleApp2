using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program5
    {
        static void Main(string[] args)
        {
            int a = 0, myWord = 1;
            string str = "Hello World!";
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    myWord++;
                }
                a++;
            }
            Console.Write("Number of words in the string = {0}\n", myWord);
        }
    }
}
    

