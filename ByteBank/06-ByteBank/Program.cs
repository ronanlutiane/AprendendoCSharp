﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Alice Alessandra Dias";
            cliente.Cpf = "367.620.520 - 02";
            cliente.Profissao = "Programadora Full Stack";

            conta.Saldo = -10;
            conta.Titular = cliente;
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);


        Console.ReadLine();
        }
    }
}
