using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    public class Telefone
    {
        private TipoTelefone tipotelefone;
        private string ddd;
        private string numero;
        
        public TipoTelefone TipoTelefone
        {
            get { return tipotelefone; }
            set { tipotelefone = value; }
        }
        
        public string DDD
        {
            get { return ddd; }
            set { ddd = value; }
        }
        
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Telefone(TipoTelefone tpTelefone, string tpDDD, string tpNumero)
        {
            this.TipoTelefone = tpTelefone;
            this.DDD = tpDDD;
            this.Numero = tpNumero;
        }
        
    }
}
