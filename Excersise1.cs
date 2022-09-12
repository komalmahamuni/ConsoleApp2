using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Excersise1
    {
        public static void printMissingElements(int[] arr, int N)
        {
            int count = 0;
            for (int i = arr[0]; i <= arr[N - 1]; i++)
            {

               
                if (arr[count] == i)
                {

                    
                    count++;
                }
                else
                {

                    
                    Console.Write(i + " ");
                }
            }
        }






        static void Main(string[] args)
        {
           
            int[] arr = { 1,2,3,4,5,7,8,10 };
            int N = arr.Length;

            
            printMissingElements(arr, N);
        }
    }
}
    

