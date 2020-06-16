using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6___2do
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int n;
            Console.Write("Digite el numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    b++;
                }
            }
            if (b != 2)
            {
                Console.WriteLine(n + " No es primo");
            }
            else
            {
                Console.WriteLine(n + " Si es primo");
            }
            Console.ReadKey();
        }
    }
}
