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

            c.Cliente = "Gabriel";
           // c.Saldo = 100;        agora com o enpsulamento fica privado a atribuicao de saldo 

            //==================Operação de Deposito========================
            double valor = 100;
            c.Depositar(valor);

            //=====================Operação de Saque========================
            double valor1 = 50;
            c.Sacar(valor1);

            //==================Resultado do Saldo Atual========================
            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo); ;

            Console.ReadKey ();
        }
    }
}
