﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__AtribuidoesDeVariaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            int idadegustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadegustavo);
            Console.ReadLine();
        }
    }
}
