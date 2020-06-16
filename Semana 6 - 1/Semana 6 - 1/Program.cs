using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 7;
            int r = 0;

            while (a <= 12)
            {
                r = a * b;

                    Console.WriteLine(a + " * " + b + " = " + r);

                a = a + 1;
            } 
                Console.ReadKey();
        }
    }
}
