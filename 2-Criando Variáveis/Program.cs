using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Criando_Variáveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variáveis");

            string texto = "idade = ";
            int idade = 32;

            idade = idade + 10;

            idade = idade - 5 + 2 * 2;

            Console.WriteLine(texto + " " + idade + " anos!");

            Console.Write(idade);

            Console.WriteLine("Execucao finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
