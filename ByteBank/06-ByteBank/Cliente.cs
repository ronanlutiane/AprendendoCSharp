using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank  
    // Um namespace define o proprietário dos objetos/classes/componentes que fazem parte daquele namespace. Podemos ter vários clientes, mas para o 
    // nosso caso, como a classe cliente está dentro do namespace "_05_ByteBank", fica explícito que o cliente é o cliente do Bytebank, 
    // devido ao fato de ele estar dentro do namespace do ByteBank. 

    // Nomes de namespaces normalmente nao iniciam com numeros ou traços. 

    // É uma convençao e boa pratica o uso de namespaces, mas nao uma obrigatoriedade. Podemos ter classes sem namespaces. 
    // Várias classes e objetos podem ser criados em arquivos diferentes e estes podem pertencer a um mesmo namespace. 
{
    public class Cliente
    {

        //outra forma de fazer getters e setters é digitando "prop" no editor e pressionando tab
        //Dessa forma o visual studio insira automaticamente snippets(trechos de codigo pronto) para gerar a propriedade

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TipoCliente { get; set; }
        public string Profissao { get; set; }
        public int Idade { get; set; }


        //Podemos usar o código abaixo para criar uma propriedade.
        public bool EhMaiorDeIdade //propriedade
        { 
            get 
            { 
                return Idade >= 18; 
            } 
            set 
            { 

            } 
        }

        // O get é um método que retorna valor
        // enquanto que o set é um método sem retorno.
        // No caso acima, onde não há implementação do set, podemos, inclusive, omitir o set. ficando como abaixo.
        //public bool EhMaiorDeIdade
        //{
        //    get 
        //    { 
        //        return Idade >= 18; 
        //    }
        //}


    }
}
