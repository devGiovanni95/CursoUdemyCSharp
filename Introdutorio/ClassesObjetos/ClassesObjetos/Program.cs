using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Classes e Objetos

            Pessoa p1 = new Pessoa();
            p1.nome = "Giovanni";
            p1.sobrenome = "Almeida";
            p1.anoNascimento = 1995;

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                sobrenome = "Maciel",
                anoNascimento = 1987
            };

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);
            //Utilizando metodos
            p1.Cumprimentar();
            
            Console.WriteLine();

            Console.WriteLine("Pessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);
            //Utilizando metodos
            p2.Cumprimentar();

            Console.ReadKey();
            #endregion


        }
    }
}
