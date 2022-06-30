using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    //definindo como partial o sistema entende que é continuação da outra classe declarada
    //anteriomente 
     partial class Pessoa {

        public void Apresentar()
        {
            Console.WriteLine("Olá eu sou " + nome);
        }

        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;//puxa a data do computador
        }
    }
}
