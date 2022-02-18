using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabuada C#

            Console.WriteLine("Tabuada");
            for (int linha = 1; linha <= 10; linha++)
            {
                Console.WriteLine("Tabuada do " + linha);
                for (int coluna = 1; coluna <= 10; coluna++)
                {
                    Console.WriteLine(linha + " X " + coluna + " = " + linha * coluna );
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
