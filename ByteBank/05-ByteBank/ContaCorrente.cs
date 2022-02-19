

//using _05_ByteBank;

namespace _05_ByteBank
{

    public class ContaCorrente
    {

        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;


        //funcao - Devolve um retorno
        //É uma boa prática manter no inicio das funçoes e metodos as condiçoes que impedem a continuaçao da execução desse método. 
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;


        }

        //metodo - nao tem retorno
        //nao é errado charmar uma funçao de metodo ou um metodo de funçao..apenas uma convençao.
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }

}


