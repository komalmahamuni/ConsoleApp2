using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class12
    {
        static void Main(string[] args)
        {
            int i;
            for(i=0;i<=5;i++)
            {
                if (i == 2)
                    continue;
                if (i == 4)
                    break;
                Console.WriteLine("value is" + i);
            }

        }
    }
}
