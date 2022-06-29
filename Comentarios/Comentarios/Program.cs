using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentarios
{
    internal class Program
    {
        //metodo principal
        static void Main(string[] args)
        {
            //escreve na tela Olá mundo
            Console.WriteLine("Olá Mundo!");

            //espera ate clicar uma tecla para finalizar no console 
            Console.ReadKey();

            //trabalhando com region para pode contrair trechos de codigo
            #region Primeira Parte
            Console.WriteLine("Region");
            Console.WriteLine("Region");
            Console.WriteLine("Region");
            Console.WriteLine("Region");
            Console.WriteLine("Region");
            #endregion

            //com subtitulos para saber o que tem la dentro
            #region Segunda Parte
            Console.WriteLine("Region");
            Console.WriteLine("Region");
            Console.WriteLine("Region");
            Console.WriteLine("Region");
            Console.WriteLine("Region");
            #endregion


        }
    }
}
