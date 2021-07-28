using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Veiculo
    {
        public virtual int VeiculoId { get; set; }

        public virtual string Placa { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual int Km { get; set; }

        public virtual string Motor { get; set; }

        public virtual int Ano { get; set; }

        public virtual string Documento { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual string Cor { get; set; }
    }
}
