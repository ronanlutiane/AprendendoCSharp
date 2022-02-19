using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Bruno";
            Console.WriteLine(conta.saldo);
            bool resultadoSaque = conta.Sacar(500);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(resultadoSaque);  

            conta.Depositar(500);
            Console.WriteLine(conta.saldo);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: R$ " + conta.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + conta2.saldo);
            bool resultadoTransferencia = conta.Transferir(200, conta2);
            Console.WriteLine("Saldo do Bruno: R$ " + conta.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + conta2.saldo);
            Console.WriteLine(resultadoTransferencia);

            resultadoTransferencia = conta2.Transferir(100, conta);

            Console.WriteLine("Saldo do Bruno: R$ " + conta.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + conta2.saldo);
            Console.WriteLine(resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
