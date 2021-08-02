using Domain.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mapping
{
    public class VeiculoMap : ClassMap<Veiculo>
    {
        public VeiculoMap()
        {
            Table("Veiculo");

            Id(x => x.VeiculoId).GeneratedBy.Assigned().UnsavedValue(0);

            Map(x => x.Placa).Not.Nullable().Length(10);
            Map(x => x.Motor).Length(50);
            Map(x => x.Ano);
            Map(x => x.Documento).Length(50);
            Map(x => x.Cor).Length(50);

            References(x => x.Modelo).ForeignKey("ModeloId").Cascade.None();
            References(x => x.Cliente).ForeignKey("ClienteId").Cascade.None();
        }
    }
}
