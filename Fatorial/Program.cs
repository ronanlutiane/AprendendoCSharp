using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatoriais");

            int fatorial = 1;

            for (int i = 1; i <= 10; i++)
            { 
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
                
            }

            Console.ReadLine();

        }
    }
}
