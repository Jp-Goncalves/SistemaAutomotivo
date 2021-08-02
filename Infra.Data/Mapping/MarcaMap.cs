using Domain.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mapping
{
    public class MarcaMap : ClassMap<Marca>
    {
        public MarcaMap()
        {
            Table("Marca");

            Id(x => x.MarcaId).GeneratedBy.Assigned().UnsavedValue(0);

            Map(x => x.Nome).Length(50).Not.Nullable();
            Map(x => x.Descricao).Length(150);

            HasMany(x => x.Modelos).Cascade.None();
        }
    }
}
