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


            InitializeComponent();

            #region 1 parte
            /*Definindo tamanho da tela*/
            /*  Size tamanho = new Size();
              tamanho.Width = 900;
              tamanho.Height = 450;*/


            /*
                        //muda o titulo da aplicação
                        this.Text = "Giovanni Almeida";
                        //this.Size = tamanho;

                        //Outra maneira de definir tamanho diretamente
                        this.Size = new Size(800,500);

                        //Definine se tem comandos de fechar maximizar minimizar
                        this.ControlBox = true;*/
            #endregion

        }

        /*Criando evento carregar pagina*/
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a Form";
        }

        /*evento click na janela*/
        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "Clicando no Form";
            this.Size = new Size(1080, 720);
          //this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MeuMetodo(object sender, EventArgs e)
        {

        }

        //Se excluirmos aki temos que desassociar ele das acoes de clicks
    /*    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }*/
    }
}
