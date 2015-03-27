using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    public class Contato
    {

        private string nome;
        private DateTime datanascimento;
        private string endereco;
        // private List<string> telefone;
        private List<Telefone> telefone;
        // private List<string> email;
        private List<Email> email;
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public List<Telefone> Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public List<Email> Email
        {
            get { return email; }
            set { email = value; }
        }

        public Contato()
        {
            this.email = new List<Email>();
            this.telefone = new List<Telefone>();
        }
    }
}
