using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12___CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12 - Calcula Investimento a longo prazo");
            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;
            int tempoInvestido = 0; 
            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    //Console.WriteLine("Após " + contadorMes + " meses, voce terá R$ " + valorInvestido);
                }

                fatorRendimento += 0.0010;
                tempoInvestido = contadorAno;
            }

            Console.WriteLine("O prazo do investimento foi de " + tempoInvestido + " anos.");
            Console.WriteLine("Ao término do investimento, voce terá R$ " + valorInvestido);

            

            //Exercício: Transformar o While abaixo em for

            //int contador = 1;
            //while (contador <= 10)
            //{
            //    Console.WriteLine(contador);
            //    contador++;
            //}

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }

            Console.ReadLine();
        }
    }
}
