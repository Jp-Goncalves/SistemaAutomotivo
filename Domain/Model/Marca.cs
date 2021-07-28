﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Marca
    {
        public virtual string Nome { get; set; }

        public virtual string Descricao { get; set; }

        public IList<Modelo> Modelos { get; set; }
    }
}