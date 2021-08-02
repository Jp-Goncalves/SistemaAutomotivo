﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Produto
    {
        public virtual int ProdutoId { get; set; }
        public virtual string Nome { get; set; }

        public virtual string Descricao { get; set; }

        public virtual decimal Valor { get; set; }
    }
}
