using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(80001, 863112154);

          

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas); //acessando a propriedade de quantidade da conta corrente

            //conta.Numero = 863112154;
            //conta.Agencia = 80001;

            conta.Agencia = -10;
            
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente conta1 = new ContaCorrente(80001, 863112155);
           
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            //Este tipo de codigo é uma incoerencia. nao deveria ser permitido alterar uma propriedade da classe de fora dela. 
            //ContaCorrente.TotalDeContasCriadas = 1000;

            Console.ReadLine();
        }
    }
}
