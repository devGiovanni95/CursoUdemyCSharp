using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Forma
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int Altura { get;  set; }
        public int Largura { get;  set; }
        public int Raio { get;  set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }
        
        public virtual void Area()
        {
           // Console.WriteLine("Preparando-se para desenhar");
        }

    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            //pegando as implementações da Classe base para reaproveitar os codigos
            base.Desenhar();
            Console.WriteLine("Desenhando um Circulo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("A area do Circulo " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            //Code to draw a Retangulo
            base.Desenhar();
            Console.WriteLine("Desenhando um Retangulo");
        }

        public override void Area()
        {
            double area = Largura * Altura;
            Console.WriteLine("A area do Retangulo " + area);
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            //Code to draw a Triangulo
            Console.WriteLine("Desenhando um Triangulo");
        }

        public override void Area()
        {
            double area = (Largura * Altura)/2;
            Console.WriteLine("A area do Triangulo " + area);
        }

    }

}
