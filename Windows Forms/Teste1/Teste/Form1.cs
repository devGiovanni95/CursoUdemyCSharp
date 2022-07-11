using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste1

{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            /*Definindo tamanho da tela*/
          /*  Size tamanho = new Size();
            tamanho.Width = 900;
            tamanho.Height = 450;*/

            InitializeComponent();
            //muda o titulo da aplicação
            this.Text = "Giovanni Almeida";
            //this.Size = tamanho;

            //Outra maneira de definir tamanho diretamente
            this.Size = new Size(800,500);

            //Definine se tem comandos de fechar maximizar minimizar
            this.ControlBox = true;

        }
    }
}
