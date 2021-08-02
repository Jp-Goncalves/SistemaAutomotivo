using Domain.Enum;
using System;
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

        public virtual DateTime DataEntrada { get; set; }

        public virtual DateTime DataSaida { get; set; }

        public virtual int  Km { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}