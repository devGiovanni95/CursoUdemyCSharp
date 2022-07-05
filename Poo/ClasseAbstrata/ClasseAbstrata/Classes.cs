using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humanos.Olhos");
        }
        public virtual void Cabelos()
        {
            Console.WriteLine("Humanos.Cabelos");
        }
    }
    
    class Pessoa : Humano
    {
        /*A partir deste momento nao pode mais
         * ser alterado ou modificado por qualquer outra classe com herança*/
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }

    class Homem : Pessoa
    {

        //Por isso que dá erro aki
        /*public override void Olhos()
        {
            Console.WriteLine("Homem.Olhos");
        }*/

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }
    }
}
