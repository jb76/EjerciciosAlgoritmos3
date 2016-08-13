using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasTresAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
                    float suma;
        float promedio;

        Console.WriteLine("Escribe el codigo del alumno");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Escribe el nombre del alumno");
        string b = Console.ReadLine(); 

        Console.WriteLine("Escribe las notas de fisica");
        int c = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Escribe las notas de programacion");
        int d = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Escribe las notas de quimica");
        int e = Convert.ToInt16(Console.ReadLine());
        suma = (e + d + c);
        promedio = (e + d + c)/3;
                
            Console.WriteLine("Resultado esperado:");
            Console.WriteLine("Sin rodar {0}",a);
            Console.WriteLine("Nombre del estudiante {0}", b);
            Console.WriteLine("Nota total {0}", suma);
            Console.WriteLine("Promedio es {0}", promedio);
           
        Console.ReadLine();

        }
    }
}
