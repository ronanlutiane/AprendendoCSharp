using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_do_Círculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio da circunferência");
            double raio = double.Parse(Console.ReadLine());
            double area = Math.PI * (raio * raio);
            Console.WriteLine("Área do círculo = " + Convert.ToString(area));
            Console.ReadLine();
        }
    }
}
