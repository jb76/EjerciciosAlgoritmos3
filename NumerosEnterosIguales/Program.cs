using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosEnterosIguales
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            Console.WriteLine("Escribe el primer valor");
            numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor");
            numero2 = Convert.ToInt16(Console.ReadLine());
            if (numero1 == numero2)
                Console.WriteLine("Ambos son iguales");
            if (numero1.CompareTo(numero2) > 0)
                Console.ReadLine();
            Console.ReadKey();
        }
    }

}
    

