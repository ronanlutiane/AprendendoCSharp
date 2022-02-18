using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13___ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 13 - For's encadeados. ");

            //*
            //**
            //***
            //****
            //*****
            //Escrevendo asteriscos com o break
             for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }


            //Uma forma diferente de fazer o desenho com asteriscos. 

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                    //if (contadorColuna >= contadorLinha)
                    //    break;
                }
                Console.WriteLine();
            }


            Console.ReadLine(); 
        }
    }
}
