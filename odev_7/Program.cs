using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int a = 1; a<=4; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
