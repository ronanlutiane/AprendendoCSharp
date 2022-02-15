using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Variaveis ponto flutuante");

            double salario = 1200.70;
            double idade = 35;
            idade = idade / 2;

            idade = 35 / 2;
            Console.WriteLine("Salario = " + salario);
            Console.WriteLine(idade + " Anos!");
            Console.WriteLine("Fim da execução. Tecle 'Enter' para continuar ");
            Console.ReadLine();
        }
    }
}
