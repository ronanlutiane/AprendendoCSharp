using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula poupança");

            double valorInvestido = 1000;

            //0.36% = 0.0036
            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Após 1 mês, voce terá R$ " + valorInvestido);

            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Após 2 meses, voce terá R$ " + valorInvestido);

            int contadorMes = 1;
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, voce terá R$ " + valorInvestido);

                //contadorMes = contadorMes + 1;
                //ContadorMes += 1 ;
                contadorMes++;  
            }
            Console.ReadLine();
        }
    }
}
