using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TempGradosCentigrados
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la temperatura");
            int A = Convert.ToInt16(Console.ReadLine());


            if (A <= 0)

                Console.WriteLine("El clima es para congelarse");


            else
            {
                if (A >= 1 && A <= 10)
                    Console.WriteLine("El clima es es muy frio");

                else
                {
                    if (A >= 11 && A <= 20)
                        Console.WriteLine("El clima es frio");

                    else
                    {
                        if (A >= 21 && A <= 30)
                            Console.WriteLine("El clima es normal");


                        else
                        {
                            if (A >= 31 && A <= 40)
                                Console.WriteLine("El clima es caliente");


                            else
                            {
                                Console.WriteLine("El clima es muy caliente");

                            }


                        }

                    }

                }

            }
            Console.ReadLine();
        }
    }
}












