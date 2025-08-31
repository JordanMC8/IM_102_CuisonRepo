using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_looping
{
    class Program
    {
        static void Main(string[] args)
        {
            //output hello World 10 times
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine("Hello World");
            }

            //output right triangle
            for (int y = 1; y <= 10; y++)
            {
                for (int z = 1; z <= y; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
