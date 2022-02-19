
namespace _07_ByteBank
{

    public class ContaCorrente
    {

        private Cliente _titular;
        private int _agencia;
        private int _numero;
        private double _saldo = 100; //Convençao de nomeaçao de atributos privados. iniciar com "_"


        //a palavra reservada static define uma caracteristica/propriedade pertencente à classe como um todo
        //esta propriedade não é especifica de apenas um objeto da classe, mas de todos em conjunto, isto é, é compartilhado por todos os objetos. Não é caractristica dos objetos.  
        public static int TotalDeContasCriadas { get; private set; } 

        //o codigo abaixo nao é necessário pois posso fazer como acima e tornar o set da propriedade privado mantendo o get publico.
        //public static int ObterTotalDeContasCriadas()
        //{
        //    return TotalDeContasCriadas;
        //}


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
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
               
        }

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _numero = value;
                
            }
        }

        //Construtor da Classe - obriga a informar os campos abaixo
        public ContaCorrente (int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++; //incrementando a propriedade que conta o total de contas criadas. 
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
    }

}


