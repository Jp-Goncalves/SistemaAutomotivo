using Domain.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mapping
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Table("Cliente");

            Id(x => x.ClienteId).GeneratedBy.Identity().UnsavedValue(0);

            Map(x => x.Nome).Length(50).Not.Nullable();
            Map(x => x.Endereco).Length(250);
            Map(x => x.Telefone).Length(10);
            Map(x => x.Celular).Length(10);

            HasMany(x => x.Servicos).Cascade.None();
        }
    }
}
