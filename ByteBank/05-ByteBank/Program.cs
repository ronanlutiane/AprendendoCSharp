using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Cliente c1 = new Cliente();
            //c1.nomeCliente = "Aline Elza Luzia Lopes";
            //c1.tipoCliente = "Pessoa Fisica";
            //c1.cpf = "419.565.645-19";
            //c1.profissao = "Vendedora";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = c1;

            conta.titular = new Cliente();

            conta.titular.nomeCliente = "Aline Elza Luzia Lopes";
            conta.titular.cpf = "419.565.645-19";
            conta.titular.profissao = "Vendedora";
            conta.titular.tipoCliente = "Pessoa Fisica";

            if (conta.titular == null)
            {
                Console.WriteLine("ops, a referência é nula");
            }

            conta.saldo = 500;
            conta.agencia = 531;
            conta.numero = 531000001;

            //Console.WriteLine(c1.nomeCliente);
            Console.WriteLine(conta.titular.nomeCliente);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.tipoCliente);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();

        }
    }
}
