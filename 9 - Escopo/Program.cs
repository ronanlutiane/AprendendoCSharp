using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadejoao = 16;
            bool precisaderesponsavel = idadejoao < 18;
            bool estaacompanhadodospais ;
            string mensagemadicional;

            estaacompanhadodospais = true;

            if (estaacompanhadodospais == true)
            {
                mensagemadicional = "João está acompanhado";
            }
            else
            {
                mensagemadicional = "Jõao não está acompanhado";
            }

            if (precisaderesponsavel == true && estaacompanhadodospais == false)
            {

                Console.WriteLine("Joao não possui mais de 18 anos e não está acompanhado dos pais. Não pode entrar.");

            }
            //if (idadejoao >= 18 || estaacompanhadodospais == true)
            //{
            //    Console.WriteLine("Joao pode entrar.");
            //}
            else
            {
                //Console.WriteLine("Joao não possui mais de 18 anos e não está acompanhado dos pais. Não pode entrar.");
                Console.WriteLine("Joao pode entrar.");
                Console.WriteLine(mensagemadicional);
            }

            Console.ReadLine();
        }
    }
}
