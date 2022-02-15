using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDeCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma1, soma2, dig1, dig2;
            soma1 = 0;
            soma2 = 0;
            Console.WriteLine("Digite um numero de CPF (Apenas numeros)");
            String cpf = Console.ReadLine();
            //Console.WriteLine("CPF digitado = " + cpf);
            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF inválido!");
            }
            else
            {
                string iniciocpf = cpf.Substring(0, 9);
                //Console.WriteLine(iniciocpf);
                int[] tabela1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] tabela2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                for (int i = 0; i < 9; i++)
                {
                    soma1 += int.Parse(iniciocpf[i].ToString()) * tabela1[i]; // iniciocpf[i] indexa o caracter na posiçao i da string iniciocpf
                }
                //Console.WriteLine(soma1);
                if (soma1 % 11 < 2)
                {
                    dig1 = 0;
                }
                else
                {
                    dig1 = 11 - (soma1 % 11);
                }
                //Console.WriteLine("Primeiro Dígito = " + dig1);
                String inicioCpf2 = cpf.Substring(0, 10);
                //Console.WriteLine(inicioCpf2);
                if (int.Parse(inicioCpf2[9].ToString()) == dig1) //inicioCpf2[10] agora indexa o caracter na posiçao 9 da string inicioCpf2
                {
                    for (int j = 0; j < 10; j++)
                    {
                        soma2 += int.Parse(inicioCpf2[j].ToString()) * tabela2[j];
                    }
                    //Console.WriteLine(soma2);
                    if (soma2 % 11 < 2)
                    {
                        dig2 = 0;
                    }
                    else
                    {
                        dig2 = 11 - (soma2 % 11);
                    }
                    //Console.WriteLine(dig2);
                    if (int.Parse(cpf[10].ToString()) == dig2) // indexador apontando para a ultima posiçao da string cpf (o indexador de strings funciona como no array, indo de 0 a X sendo 0 a primeira posição e X a ultima posição)
                    {
                        Console.WriteLine("CPF Válido");
                    }
                    else
                    {
                        Console.WriteLine("CPF inválido!");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
