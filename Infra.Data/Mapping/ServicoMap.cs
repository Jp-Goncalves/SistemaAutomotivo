using Domain.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mapping
{
    public class ServicoMap : ClassMap<Servico>
    {
        public ServicoMap()
        {
            Table("Servico");

            Id(x => x.ServicoId).GeneratedBy.Identity().UnsavedValue(0);

            Map(x => x.Descricao).Length(250);
            Map(x => x.Valor);
            Map(x => x.Detalhes).Length(250);
            Map(x => x.StatusEnum);
            Map(x => x.DataEntrada);
            Map(x => x.DataSaida);
            Map(x => x.Km).Not.Nullable();

            HasMany(x => x.Pecas).Cascade.None();
            References(x => x.Cliente).ForeignKey("ClienteId").Cascade.None();
        }
    }
}
