using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro : Veiculo //o ":" no c significa que esta herdando
    {
     //   public string Cor { get; set; }
      //  public string Marca { get; set; }
        public int VelocidadeMaxima{ get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("O carro ligou o motor");
        }
        
   /* Iremos criar uma conexao atravez da heranca
    * public void Acelerar()
        {
            Console.WriteLine("Acelerou!");
        }
        
        public void Parar()
        {
            Console.WriteLine("Parou!");
        }*/

    }
}
