﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursiva r = new Recursiva();
            r.Executar("Olá Mundo! ", 5);

            r.ExecutarRecursivo("Olá Mundo! ", 5);

            

            Console.ReadKey();
        }
    }
}
