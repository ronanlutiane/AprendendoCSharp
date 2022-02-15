using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversões");

            double salario;
            salario = 1200.50;

            // o int é um tipo numerico de 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // o long é uma variavel de 64 bits
            string texto = "int idadedouniverso = 13000000000;";
            long idadedouniverso = 1300000000000000000;

            //o short é uma variavel de 16 bits
            short quantidade = 15000;

            // o float é uma variavel ponto flutuante (com decimais) de precisao menor que o double
            // ao usar o float eu devo usar o f ao final do numero para evitar erro de complilaçao
            float altura = 1.80f;


            Console.WriteLine (idadedouniverso);
            Console.WriteLine(quantidade);
            Console.WriteLine (altura);
            Console.WriteLine(texto);

            Console.WriteLine("fim da Execução. Tecle 'enter' para continuar");
            Console.ReadLine();
        }
    }
}
