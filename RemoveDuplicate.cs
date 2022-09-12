using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class RemoveDuplicate
    {
        static void Main(string[] args)
        {
            String inputStr, resultStr = String.Empty;
            Console.WriteLine("Enter a string:");
            inputStr = Console.ReadLine();
            for(int i=0;i<inputStr.Length; i++)
            {
                if(!resultStr.Contains(inputStr[i]+""))
                {
                    resultStr += inputStr[i];

                }
            }
            Console.WriteLine("Final String:" + resultStr);
        }
    }
}
