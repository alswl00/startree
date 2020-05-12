using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8, i, j, k;
            for(i = 1; i <= num; i++)
            {
                for(j = num - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
