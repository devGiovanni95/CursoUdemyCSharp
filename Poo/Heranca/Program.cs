using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();

            c.VelocidadeMaxima=20;
            c.Cor="Verde";
            c.Marca="Corsa";
            c.LigarMotor();
            c.Acelerar();
            c.Parar();

            Console.WriteLine("A cor do carro é: "+c.Cor);
            Console.WriteLine("A marca do Carro é: "+c.Marca);
            Console.WriteLine("A velocidade Máxima é de : "+ c.VelocidadeMaxima+" Km/h");
            Console.WriteLine();

            
            b.Cor="Preta";
            b.Marca="Bmx";
            b.Pedalar();
            b.Acelerar();
            b.Parar();
          
            Console.WriteLine("A cor da bicicleta é: "+b.Cor);
            Console.WriteLine("A marca da bicicleta é: "+b.Marca);
            Console.WriteLine();


            Console.ReadKey();
     
        }
    }
}
