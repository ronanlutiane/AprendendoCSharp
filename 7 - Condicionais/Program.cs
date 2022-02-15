using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadejoao = 16;
            bool estaacompanhadodospais = false;

            estaacompanhadodospais = true;

            if (idadejoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos. Pode entrar.");
            }
            else
            {
                if (estaacompanhadodospais == true)
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos, mas está acompanhado dos pais. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("Joao não possui mais de 18 anos e não está acompanhado dos pais. Não pode entrar.");
                }
            }

            Console.ReadLine();
        }
    }
}
