using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6___3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num;
            string n;
            
            Console.Write("introduzca un numero: ");
            num = Convert.ToInt64(Console.ReadLine());
            n = num.ToString();

            Console.WriteLine("El numero " + num + " tiene " + n.Length + " digitos");
            Console.ReadKey();
        }
    }
}
