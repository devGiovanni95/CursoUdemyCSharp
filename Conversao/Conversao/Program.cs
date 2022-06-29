using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão implicita
            //byte num1 = 100; //8 bits, de0 a 255
            //ushort num2; //32 bits 0 a 65.535
            //float num3 = 1250.45f;
            //double num4 = num3;

            //num2 = num1;

            //Console.WriteLine(num2);   
            //Console.WriteLine(num4);

            //num3 = num1;
            //Console.WriteLine(num3);

            //int numero = 'C';//ele aceita pois ele salva o codigo numerico da letra 

            //Console.ReadKey();
            #endregion

            #region Conversao explicita 

            //ushort num1 = 500;
            //byte num2 = (byte)num1;
            //// neste caso houve perda de dados pois vimos que cada tipo tem uma limtação com relação ao tamanho do 

            //float num3 = 2500.786f;
            //int num4 = (int)num3;

            ////char letra = 97;      nao aceita deste modo
            //char letra1 = (char)97; //precisamos colocar a conversao antes



            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine(letra1);
            //Console.ReadKey();

            #endregion

            #region Conversão com Parse

            //string txtNumero = "1985";

            ////int numero = txtNumero;  nao aceita
            //int numero = int.Parse(txtNumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57");
            //double num3 = double.Parse("125623.57");

            //float num4 = float.Parse("457,75");
            //float num5 = float.Parse("457.75");

            //Console.WriteLine(numero);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine(num5);
            //Console.ReadKey();


            #endregion


            #region Classe Convert

            //string texto = 2500; da um erro
            string texto1 = Convert.ToString( 2500);

            double num1 = Convert.ToDouble(false);
            
            int num2 = Convert.ToInt32('C');

          //  int num3 = Convert.ToDouble('C'); nao aceita essa conversao

            Console.WriteLine(texto1);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadKey();

            #endregion

        }
    }
}
