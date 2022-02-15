using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5 - Caractetes e Textos");

            //character

            char primeiraletra = 'r';

            Console.WriteLine(primeiraletra);

            primeiraletra = (char)65;
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)(primeiraletra + 1);

            Console.WriteLine(primeiraletra);

            string titulo = "Ronan Está tentando aprender C# pela terceira vez...";

            string titulo2 = "ele ja sabia alguma coisa...mas nao praticou e esqueceu tudo...";
            Console.WriteLine(titulo);
            Console.WriteLine(titulo2);
            Console.WriteLine("Fim da Execuçao. Tecle 'Enter' para finalizar");
            Console.ReadLine();
        }
    }
}
