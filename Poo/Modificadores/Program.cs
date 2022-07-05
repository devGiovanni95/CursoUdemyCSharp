using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
           // t.nome = "";
            t.sobrenome = "Eminem";
           //t.Metodo1();
            t.Executar();

            Homem h = new Homem();
            h.idade = 18;
            Console.WriteLine(h+"\n"+t.sobrenome);

            //Como definimos nome privado ele e restrito
            //h.nome = "Eli"; 

            //Como definimos nome protected ele e restrito
            //h.sobrenome = "Soares"; 

            Console.ReadKey();

        }
    }
}
