using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Condicionais_Parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais Parte 2");

            int idadejoao = 16;
            bool estaacompanhadodospais = false;

            //estaacompanhadodospais = true;

            if (idadejoao >= 18 || estaacompanhadodospais == true)
            {
                Console.WriteLine("Joao pode entrar.");
            }
            else
            {
                Console.WriteLine("Joao não possui mais de 18 anos e não está acompanhado dos pais. Não pode entrar.");

            }

            Console.ReadLine();
        }
    }
}
