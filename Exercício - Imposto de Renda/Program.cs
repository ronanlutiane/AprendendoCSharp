using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício___Imposto_de_Renda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 'Imposto de Renda'.");

            double salario;
            double valorDeducao;
            double Aliquota;
            string mensagem;
            double deducaoDependente = 189.59;

            salario = 5000;

            if (salario < 1903.98)
            {
                Aliquota = 0;
                valorDeducao = 0;
                mensagem = "Você é isento do Imposto de renda!";
                Console.WriteLine("Salário: R$" + salario + " " + mensagem);
            }
            else if (salario <= 2826.65)
            {
                Aliquota = 7.5;
                valorDeducao = 142.8;
                mensagem = "Alíquota " + Aliquota + "%. Você pode deduzir até R$" + valorDeducao;
                Console.WriteLine("Salário: R$" + salario + " " + mensagem + " e mais R$" + deducaoDependente + " por dependente se houver.");
            }
            else if (salario <= 3751.05)
            {
                Aliquota = 15;
                valorDeducao = 354.8;
                mensagem = "Alíquota " + Aliquota + "%. Você pode deduzir até R$" + valorDeducao;
                Console.WriteLine("Salário: R$" + salario + " " + mensagem + " e mais R$" + deducaoDependente + " por dependente se houver.");
            }
            else if (salario <= 4664.68)
            {
                Aliquota = 22.5;
                valorDeducao = 636.13;
                mensagem = "Alíquota " + Aliquota + "%. Você pode deduzir até R$" + valorDeducao;
                Console.WriteLine("Salário: R$" + salario + " " + mensagem + " e mais R$" + deducaoDependente + " por dependente se houver.");
            }
            else
            {
                Aliquota = 27.5;
                valorDeducao = 869.36;
                mensagem = "Alíquota " + Aliquota + "%. Você pode deduzir até R$" + valorDeducao;
                Console.WriteLine("Salário: R$" + salario + " " + mensagem + " e mais R$" + deducaoDependente + " por dependente se houver.");
            }

            Console.ReadLine();
        }
    }
}
