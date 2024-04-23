using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeContatosGOD_VS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIncluirContato_Click(object sender, EventArgs e)
        {
            // Cria um objeto da classe contato.
            Contato contato = new Contato();
            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            listBoxContatos.Items.Add(contato.ToString());
        }
    }
}
