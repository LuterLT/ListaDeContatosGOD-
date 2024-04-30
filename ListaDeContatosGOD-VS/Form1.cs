using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDeContatosGOD_VS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Um vetor de COntatos
        private Contato[] contatos = new Contato[1];

        //método para salvar o contato
        private void Escrever(Contato contato)
        {
            StreamWriter escreverEmArquivo = new StreamWriter("Contatos.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos.Length; x++)
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Telefone);
            }
            escreverEmArquivo.Close();
        }

        private void Ler()
        {
            StreamReader lerArquivo = new StreamReader("Contatos.txt");
            contatos = new Contato[Convert.ToInt32(lerArquivo.ReadLine())];

            for (int x = 0; x < contatos.Length; x++)
            {
                contatos[x] = new Contato();
                contatos[x].Nome = lerArquivo.ReadLine();
                contatos[x].Sobrenome = lerArquivo.ReadLine();
                contatos[x].Telefone = lerArquivo.ReadLine();
            }

            lerArquivo.Close();

        }
        //Atualiza a tela do programa com os contatos
        private void Exibir()
        { 
            //limpa a lista de contatos
            listBoxContatos.Items.Clear();
            for (int x = 0; x < contatos.Length; x++)
            {
                listBoxContatos.Items.Add(contatos[x].ToString());
            }
        }

        private void LimparFormulario()
        { 
            textBoxNome.Text = String.Empty;
            textBoxSobrenome.Text = String.Empty;
            textBoxTelefone.Text = String.Empty;
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIncluirContato_Click_1(object sender, EventArgs e)
        {
            // Cria um objeto da classe contato.
            Contato contato = new Contato();
            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            //listBoxContatos.Items.Add(contato.ToString());
            Escrever(contato);
            Organizar();
            Ler();
            Exibir();
            LimparFormulario();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Organizar();
            Exibir();
        }
        private void Organizar()
        {
            Contato temporario;
            bool troca = true;

            do
            {
                troca = false;

                for (int x = 0; x < contatos.Length - 1; x++)
                {
                    if (contatos[x].Nome.CompareTo(contatos[x + 1].Nome) > 0)
                    { 
                        temporario = contatos[x];
                        contatos[x] = contatos[x + 1];
                        contatos[x + 1] = temporario;
                        troca = true;
                    }
                }
            } while (troca == true);
        }

        private void buttonOrganizar_Click(object sender, EventArgs e)
        {
            Organizar();
            Exibir();
        }
    }
}
