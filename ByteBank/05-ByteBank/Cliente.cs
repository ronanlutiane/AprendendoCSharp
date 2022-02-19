using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank  
    // Um namespace define o proprietário dos objetos/classes/componentes que fazem parte daquele namespace. Podemos ter vários clientes, mas para o 
    // nosso caso, como a classe cliente está dentro do namespace "_05_ByteBank", fica explícito que o cliente é o cliente do Bytebank, 
    // devido ao fato de ele estar dentro do namespace do ByteBank. 

    // Nomes de namespaces normalmente nao iniciam com numeros ou traços. 

    // É uma convençao e boa pratica o uso de namespaces, mas nao uma obrigatoriedade. Podemos ter classes sem namespaces. 
    // Várias classes e objetos podem ser criados em arquivos diferentes e estes podem pertencer a um mesmo namespace. 
{
    public class Cliente
    {

        public string nomeCliente;
        public string tipoCliente;
        public string cpf;
        public string profissao;

    }
}
