using Domain.Enum;
using System.Collections.Generic;

namespace Domain.Model
{
    public class Servico
    {
        public virtual int ServicoId { get; set; }

        public virtual string Descricao { get; set; }

        public virtual IList<Produto> Pecas { get; set; }

        public virtual decimal Valor { get; set; }

        public virtual string Detalhes { get; set; }

        public virtual StatusEnum StatusEnum { get; set; }
    }
}