using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contado1 = 1;

            Console.WriteLine("numeros de 1 a 10 no while");
            while (contado1 <=10)
            {
                Console.WriteLine(contado1);
                contado1++;
            }

            Console.WriteLine();
            Console.WriteLine("numeros de 1 a 10 no for");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("numeros de 1 a 10 no for em linhas e colunas diferentes");
            for (int linha = 1; linha <= 10; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    Console.Write(coluna);
                }
                Console.WriteLine();
            }




            Console.ReadLine();
        }
    }
}
