using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Multiplos do 3

            Console.WriteLine("Múltiplos do numeral 3 entre 1 e 100");
            Console.WriteLine("Usando o operador %(módulo): ");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Usando Cálculo: ");

            for (int i = 3; i <= 100; i+=3)
            {
                Console.Write(i + " ");
               
            }

            Console.ReadLine();

        }
    }
}
