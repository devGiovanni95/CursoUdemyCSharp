using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c._cliente = "Gabriel";
            c._saldo = 100;

            //==================Operação de Deposito========================
            double valor = 100;
            c.Depositar(valor);

            //=====================Operação de Saque========================
            double valor1 = 50;
            c.Sacar(valor1);

            //==================Resultado do Saldo Atual========================
            Console.WriteLine("Cliente: " + c._cliente);
            Console.WriteLine("Saldo: " + c._saldo); ;

            Console.ReadKey ();
        }
    }
}
