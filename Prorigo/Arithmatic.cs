using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Prorigo
{
    class Arithmatic
    {public static int Arithmatic_Progression(int t2,int t3,int n)
        {
            int diff = t3 - t2;
            int t4 = t3;
            for( int i=4;i<=n;i++)
            {
                t4 = t4 + diff;
            }
            return t4;   
        }

        static void Main(string[] args)
        {
            Arithmatic_Progression(3, 7, 8);

        }
    }
}
