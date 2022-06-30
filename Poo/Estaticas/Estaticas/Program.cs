using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //utilizando a classe statica para passar o parametro por  ->"."<-
            Matematica.taxa = 10;

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Diminuir(200);

            Console.WriteLine("O valor de 1: " + valor1);
            Console.WriteLine("O valor de 2: " + valor2);

            Console.ReadKey();

        }
    }
}
