using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Metodos
    {
        //Metodos Simples 
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, Seja Bem Vindo");
        }

        //Metodos com parametros
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos");
        }

        //Passagem de parametros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }

        //Passagem de parametros por ref
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }

        //Metodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            string nomeCompleto = nome + " " + sobrenome;
            return nomeCompleto;
            //ou -> return  nome + " " + sobrenome;
        }

        //Podemos fazer a conversao explicita
        public int CodigoChar(char caractere)
        {
            int codigo = (int)caractere;
            return codigo;
        }

        //ou implicita
        public int CodigoChar1(char caractere)
        {
            return caractere;
        }

        //podemos retornar sem passar parametros
        public double ValorPi()
        {
            return 3.1415;
        }

        //Sobrecargas de Metodos
        public string Cumprimentar(string nome)
        {
            Console.WriteLine("Olá, " + nome + " Seja Bem Vindo");
            return nome;
        }

        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom Dia " + nome : "Boa tarde " + nome; 
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }
        
        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }


    }
}
