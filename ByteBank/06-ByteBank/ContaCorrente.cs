
namespace _06_ByteBank
{

    public class ContaCorrente
    {

        private Cliente _titular;
        private double _saldo = 100; //Convençao de nomeaçao de atributos privados. iniciar com "_"


        //Get e set da classe (Propriedades)
        public Cliente Titular
        {
            get { return _titular; }
            set { _titular = value; }    
        }

        public double Saldo //Convençao de nomeaçao de propriedade. Primeira letra em maiusculo. 
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }


        // A palavra reservada value existe somente dentro de um setter.



        //Outra forma de fazer gets e sets
        //se eu estou apenas definindo informaçoes e nao preciso de validação ou o campo nao tem regras nao preciso nem mesmo criar o campo no inicio da classe.
        //campo nao foi criado no inicio da classe por que com a construçao abaixo nao é necessário. 
        //Pode ser aplicado ao titular tb. 
        public int Agencia
        {
            get;
            set;
        }

        public int Numero
        {
            get;
            set;
        }

        //funcao - Devolve um retorno
        //É uma boa prática manter no inicio das funçoes e metodos as condiçoes que impedem a continuaçao da execução desse método. 
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;


        }

        //metodo - nao tem retorno
        //nao é errado charmar uma funçao de metodo ou um metodo de funçao..apenas uma convençao.
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

        // os metodos abaixo foram alterados para a propriedade Get/set no inicio da classe


        //public double GetSaldo() 
        //{
        //    return saldo;
        //}

        //public void SetSaldo(double saldo) //convenção e boa prática de programação utilizar get e set para retornar e definir propriedades de uma classe. 
        //{
        //    if (saldo < 0)
        //    {
        //        return; //return sem o que ele retorna em um metodo void tem o mesmo efeito de um metodo que possui retornos. 
        //    }
        //    else
        //    {
        //        this.saldo = saldo;
        //    }
        //}
    }

}


