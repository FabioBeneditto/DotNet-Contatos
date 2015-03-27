using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    public class Email
    {
        private string endereco;
        private TipoEmail tipo;
        
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
       
        public TipoEmail Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Email(string endEmail, TipoEmail tpEmail)
        {
            this.Endereco = endEmail;
            this.Tipo = tpEmail;
        }

    }
}
