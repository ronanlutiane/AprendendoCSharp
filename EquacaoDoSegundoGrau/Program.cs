using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquacaoDoSegundoGrau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Este codigo recebe os valores de A, B e C no input do usuário e calcula as raízes da Equação 
            //do segundo grau baseado neste input
            {
                int resposta;
                do
                {
                    Console.WriteLine("Informe o valor de A: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor de B: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor de C: ");
                    int c = int.Parse(Console.ReadLine());
                    string equacao = a + "X^2 + " + b + "X + " + c + " = 0";
                    double delta = (b * b) - 4 * (a * c);
                    if (delta == 0)
                    {
                        double raiz = -b / (2 * a);
                        Console.WriteLine("Sua Equação " + equacao);
                        Console.WriteLine("Valor de delta = " + delta);
                        Console.WriteLine("Delta igual a 0, esta equação possui apenas uma raíz real: " + raiz);
                    }
                    else if (delta > 0)
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("Sua Equação " + equacao);
                        Console.WriteLine("Valor de delta = " + delta);
                        Console.WriteLine("Esta equação possui duas raízes reais: X1 = " + x1 + " e X2 = " + x2);
                    }
                    else
                    {
                        Console.WriteLine("Sua Equação " + equacao);
                        Console.WriteLine("Valor de delta = " + delta);
                        Console.WriteLine("Delta menor que 0, portanto esta equação não possui raízes reais.");
                    }
                    Console.WriteLine("Deseja executar novamente? 1 - SIM ou 2 - NÃO");
                    resposta = int.Parse(Console.ReadLine());
                }
                while (resposta == 1);
                Console.WriteLine("Fim da Execução");
            }
        }
    }
}
