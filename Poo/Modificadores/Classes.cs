using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
     class Teste
    {
        private string nome;
        public string sobrenome;

        private void Metodo1() { }

        public void Executar() { }
    }

    class Humano
    {
        //Fica invisivel para as outras classes
        //Mas pra qualquer classe que herda dela ficam disponivel
        protected string nome;

        //Fica invisivel para todas as outras classes
        private string sobrenome;
        
        //so pode ser usado na aplicação em que é implementada
        //se outra aplicação fosse usar dados desta aplicação
        //este campo nao ficaria disponivel para acesso 
        internal int idade;
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "h";
            
        }
    }
}
