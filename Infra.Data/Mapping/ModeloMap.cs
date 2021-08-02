using Domain.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mapping
{
    public class ModeloMap : ClassMap<Modelo>
    {
        public ModeloMap()
        {
            Table("Modelo");

            Id(x => x.ModeloId).GeneratedBy.Assigned().UnsavedValue(0);

            Map(x => x.Nome).Not.Nullable().Length(150);

            References(x => x.Marca).ForeignKey("MarcaId").Cascade.None();
        }
    }
}
