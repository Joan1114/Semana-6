using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6___4
{
    class Program
    {
        static void Main(string[] args)
        {
            var aleatorio = new Random();
            int NumRandom;
            string r = "";
            
            while (r.ToUpper() != "S")
            {
                NumRandom = aleatorio.Next(50, 100);
                Console.WriteLine("El numero aleatorio es: " + NumRandom);
                Console.WriteLine("S = Cerrar Aplicación; N = Generar otro numero");
                r = Console.ReadLine();
            }

        }
    }
}
