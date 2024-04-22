using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosGOD_VS
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        //Propriedades(get e set) é um controle de acesso às variáveis
        public string Nome 
        {
            get 
            {
                return nome; 
            }
            set 
            {  
                nome = value; 
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get
            { 
                return telefone;
            }
            set
            {
                if (value.Length == 11)
                { 
                    telefone = value;
                }
                else
                {
                    //País-Cidade-Telefone 11-98189-3458
                    telefone = "00-00000-0000";
                }
            }

        }
        //O método que tem o mesmo nome da Classe
        //e não retorna nada, é chamado Construtor da Classe
        public Contato() 
        { 
            Nome = "Jesus";
            Sobrenome = "Evertonliano";
            Telefone = "11-99999-9999";
        }
        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
        //Sobrescreve o método ToString()
        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}", Telefone.Substring(0, 2), Telefone.Substring(2,5), Telefone.Substring(7,4));
            return saida; 
        }
    }
}
