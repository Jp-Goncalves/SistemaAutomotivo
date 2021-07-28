using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Cliente
    {
        public virtual int ClienteId { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Endereco { get; set; }

        public virtual string Telefone { get; set; }

        public virtual string Celular { get; set; }

        public virtual IList<Servico> Servicos { get; set; }
    }
}
