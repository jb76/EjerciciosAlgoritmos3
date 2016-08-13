using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidatoVoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad1;
            
            string teclado;

            System.Console.WriteLine("\t*** Elegible Para votar ***\n\n");
            System.Console.WriteLine("Ingresa  edad: ");
            teclado = System.Console.ReadLine();
            edad1 = int.Parse(teclado);        
            System.Console.Write("\nFelicidades puedes Votar: ");
            System.Console.ReadLine();


        }
    }
}
