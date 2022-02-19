using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Gabriela";
            conta1.agencia = 863;
            conta1.numero = 863000001;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Gabriel";
            conta2.agencia = 863;
            conta2.numero = 863000002;

            Console.WriteLine(conta1 == conta2);

            
            Console.ReadLine();
        }
    }
}
