using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iratosfen = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                iratosfen[i] = i;
//                Console.WriteLine(iratosfen[i]);
            }

            for (int i = 2; i < 10000; i++)
            {
                if (iratosfen[i] != 0)
                {
                    int j = i*i;
                    while (j <= 9999)
                    {
                        iratosfen[j] = 0;
                        j += i; 
                    }
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                if (iratosfen[i] != 0) Console.Write(" " + iratosfen[i]);
            }
                Console.ReadKey();
        }
    }
}
