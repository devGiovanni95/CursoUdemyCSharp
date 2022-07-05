﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();
           // Veiculo veiculo = new Veiculo();

            c.VelocidadeMaxima = 20;
            c.Cor = "Verde";
            c.Marca = "Corsa";
            c.LigarMotor();
            c.Acelerar();
            c.Parar();

            Console.WriteLine("A cor do carro é: " + c.Cor);
            Console.WriteLine("A marca do Carro é: " + c.Marca);
            Console.WriteLine("A velocidade Máxima é de : " + c.VelocidadeMaxima + " Km/h");
            Console.WriteLine();


            b.Cor = "Preta";
            b.Marca = "Bmx";
            b.Pedalar();
            b.Acelerar();
            b.Parar();

            Console.WriteLine("A cor da bicicleta é: " + b.Cor);
            Console.WriteLine("A marca da bicicleta é: " + b.Marca);
            Console.WriteLine();

            #endregion

            Humano humano = new Humano();
            Pessoa pessoa = new Pessoa();
            Homem homem = new Homem();

            Console.WriteLine("\n Humano");
            humano.Olhos();
            humano.Cabelos();
            Console.WriteLine("\n Pessoa");
            pessoa.Olhos();
            pessoa.Cabelos();
            Console.WriteLine("\n Homem");
            homem.Olhos();
            homem.Cabelos();

            Console.ReadKey();

        }
    }
}
