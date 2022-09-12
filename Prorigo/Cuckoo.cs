using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Prorigo
{
    class Cuckoo
    {
        static int Cuckoo1(int n )
        {
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else
                return 1 * Cuckoo1(n - 1) + 2 * Cuckoo1(n - 2) + 3 * 1;
        }

 static void Main(string[] args)
        {
            int result = Cuckoo1(3);
            Console.WriteLine(result);

        }
    }
}
