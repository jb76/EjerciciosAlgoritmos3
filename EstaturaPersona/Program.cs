using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstaturaPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; string linea;
            Console.Write("Ingrese su altura: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num < 150)
            {
                Console.Write("Es de altura baja: ");
            }
            else
            {
                Console.Write("Es de altura promedio: ");
            }
            if (num > 170)
            {
                Console.Write("Es de una altura mayor a la promedio: ");
            }
            Console.ReadKey();

        }
    }
}
