using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_3_semana_3_algoritmos
{
    class program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, mayor;
            
            Console.Write("Ingrese Numero 1:");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Numero 2:");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Numero 3:");
            numero3 = int.Parse(Console.ReadLine());
            
            if (numero1 > numero2 && numero1 > numero3)
                mayor = numero1;
            else if (numero2 > numero1 && numero2 > numero3)
                mayor = numero2;
            else
                mayor = numero3;
            
            Console.WriteLine("El Mayor es :{0}", mayor);
            Console.Read();
        }
    }
}


