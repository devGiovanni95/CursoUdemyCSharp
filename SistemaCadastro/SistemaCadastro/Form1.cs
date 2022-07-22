using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {

        //Criando uma lista de pessoas
        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();
            //Inicializando a lista de pessaoas
            pessoas = new List<Pessoa>();

            //atribuindo ao ComboBox valores em sua lista
            cbEstadoCivil.Items.Add("Solteiro");
            cbEstadoCivil.Items.Add("Casado");
            cbEstadoCivil.Items.Add("Viuvo");
            cbEstadoCivil.Items.Add("Separado");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //o menos 1 quer dizer que sera um novo cadastro
            int index = -1;

            foreach (Pessoa pessoa in pessoas)
            {
                //Comparando se o nome digitado na caixa de texto ja esta cadastrado
                //servindo assim como chave primaria
                if (pessoa.Nome == txtNome.Text)
                {
                    //se a pessoa ja for cadastrada na lista ela vai ter o mesmo indice
                    //mas se nao tiver vai continuar atribuido o valor de menos um -1
                    index = pessoas.IndexOf(pessoa);
                }
            }

            //Comparando se o campo nome esta vazio
            if(txtNome.Text == "")
            {
                //Se estiver retorna uma caixa de mensagem pedindo para preencher este campo
                MessageBox.Show("Preencha o campo nome.");
                //Da um foco na caixa que precisa ser preenchida
                txtNome.Focus();
                //para nao poder continuar preenchendo 
                return;
            }


            //Comparando se o campo nome esta vazio
            if (txtTelefone.Text == "(  )      -")
            {
                //Se estiver retorna uma caixa de mensagem pedindo para preencher este campo
                MessageBox.Show("Preencha o campo telefone.");
                //Da um foco na caixa que precisa ser preenchida
                txtTelefone.Focus();
                //para nao poder continuar preenchendo 
                return;
            }

            //Criando uma variavel
            char sexo;

            //conferindo se ela esta marcada
            if (radioMasculino.Checked)
            {
                //Se estiver atribuimos um valor na 
                sexo = 'M';
            }
            else if (radioFeminino.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            //Criando uma nova pessoa
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.DataNascimento = txtData.Text;
            p.EstadoCivil = cbEstadoCivil.SelectedItem.ToString();//convertendo em txt
            p.Telefone = txtTelefone.Text;
            p.CasaPropria = checkCasa.Checked;
            p.Veiculo = checkVeiculo.Checked;
            p.Sexo = sexo;

            //se o index for -1 é uma pessoa nova entao cria um cadastro novo
            if(index < 0)
            {
                pessoas.Add(p);
            }//se nao for uma nova pessoa
            else
            {
                //ele altera os valores contidos no seu indice
                pessoas[index] = p;
            }

            //limpamos a tela quando efetuar o cadastro
            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            //depois de cadastrados vamos exibir na tela chamando a função Listar()
            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //pegando o indice onde esta sendo feito o cadastro ou que foi selecionado na lista
            int indice = lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            Listar();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //setando com valores vazios para fazer a limpeza dos dados
            txtNome.Text = "";
            txtData.Text = "";
            cbEstadoCivil.SelectedIndex = 0;
            txtTelefone.Text = "";
            checkCasa.Checked = false;
            checkVeiculo.Checked = false;
            radioMasculino.Checked = true;
            radioFeminino.Checked = false;
            radioOutro.Checked = false;
            txtNome.Focus();

        }

        private void Listar()
        {
            //Limpando todos os itens que esta na lista 
            lista.Items.Clear();

            //Criando com o foreach uma estrutura de repetição para mostrar na tela 
            //somente os nomes das pessoas cadastradas no sistema 
            foreach(Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = lista.SelectedIndex;
            Pessoa p = pessoas[indice];

            txtNome.Text = p.Nome;
            txtData.Text = p.EstadoCivil;
            cbEstadoCivil.SelectedItem = p.EstadoCivil;
            txtTelefone.Text = p.Telefone;
            checkCasa.Checked = p.CasaPropria;
            checkVeiculo.Checked = p.Veiculo;

            switch (p.Sexo)
            {
                case 'M':
                    radioMasculino.Checked = true;
                    break;
                case 'F':
                    radioFeminino.Checked = true;
                    break;
                case 'O':
                    radioOutro.Checked = true;
                    break;
            }
        }
    }
}
