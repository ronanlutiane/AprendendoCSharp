using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CalculaPoupanca___Parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11 - Calcula poupança - Parte 2");
            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes ++)
            {
                //valorInvestido = valorInvestido * 1.0036;
                //valorInvestido += valorInvestido * 0.0036;
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, voce terá R$ " + valorInvestido);
            }


            Console.ReadLine();
        }
    }
}
