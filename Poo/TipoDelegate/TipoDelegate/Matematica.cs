using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
     class Matematica
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine("A Soma é: " + (n1 + n2));
        }
        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine("A Subtração é: " + (n1 - n2));
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine("A Multiplicação é: " + (n1 * n2));
        }
        public void Dividir(int n1, int n2)
        {
            Console.WriteLine("A Divisão é: " + (n1 / n2));
        }
    }
}
