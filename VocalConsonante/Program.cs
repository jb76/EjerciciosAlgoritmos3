using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ejercicio
{
    static void Main(string[] args)
    {

        string letra;
        Console.WriteLine("INGRESE UNA LITERAL:");
        letra = Console.ReadLine();
        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")

        {
            Console.WriteLine("La Letra Es una vocal: ");

        }
        else
        {
            Console.WriteLine("La letra Es una Consonate: ");
        }
        Console.ReadKey();
    }
}





