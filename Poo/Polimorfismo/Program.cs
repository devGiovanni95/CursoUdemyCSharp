using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Polimorfismo sao todas do mesmo tipo mais tem
            //comportamentos diferentes com implementações
            //especificas na sua implementação 
            //se a classe fosse ndo tipo abstrata
            //so poderiamos instanciar as com os tipos predefinidos nao imprimindo a base
            Forma a = new Forma();
            a.Altura = 10;
            a.Largura = 10;
            a.Raio = 10;
            Forma b = new Triangulo();
            b.Altura = 10;
            b.Largura = 10;
            Forma c = new Circulo();
            c.Raio = 10;
            Forma d = new Retangulo();
            a.Altura = 10;
            a.Largura = 10;

            Console.WriteLine("Forma");
            a.Desenhar();
            a.Area();
            Console.WriteLine("Triangulo");
            b.Desenhar();
            b.Area();
            Console.WriteLine("Circulo");            
            c.Desenhar();
            c.Area();
            Console.WriteLine("Retangulo");
            d.Desenhar();
            d.Area();

            Console.ReadKey();
        }
    }
}
