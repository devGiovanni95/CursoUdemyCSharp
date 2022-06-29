﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.Cumprimentar();
            m.Somar(10, 5);
            m.Apresentar("Giovanni", 26);

            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);//Nao altera a variavel local
            m.AumentarRef(ref valor2);//altera a variavel local

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);

            Console.ReadKey();
        }
    }
}
