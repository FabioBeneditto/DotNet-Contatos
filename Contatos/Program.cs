using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contato c = new Contato();
            c.Nome = "Fabio";
            // c.Email.Add("fabiobeneditto@feevale.br");
            c.Email.Add(new Email("fabiobeneditto@feevale.br", TipoEmail.Academico));
            c.Telefone.Add(new Telefone(TipoTelefone.Movel, "51", "81375277"));

            Console.Read();
        }
    }
}
