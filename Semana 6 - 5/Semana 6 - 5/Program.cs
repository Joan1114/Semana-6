using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6___5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int cont2 = 0;

            while (cont <= 100)
            {
                if (cont % 10 == 0)
                {
                    cont2++;
                    Console.WriteLine(cont + " contiene 0");
                    if ((cont / 10) % 10 == 0)
                    {
                        cont2++;
                    }
                }
                cont++;
            }
            Console.WriteLine("En los numeros del 1 al 100 existen: " + cont2 + " ceros");
            Console.ReadKey();
        }
    }
}
