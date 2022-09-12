using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program3
    {
        static int countinString(char ch, String s)
        {
            
            if (s.Length == 0)
                return 0;
            int count = 0;

            
            if (s[0] == ch)
                count++;
            
            count += countinString(ch, s.Substring(1));


            return count;
        }
        static void Main(string[] args)
        {
            String str = "welcomeindia";
            char c = 'e';
            Console.WriteLine(countinString(c, str));
        }
    }

}

    

