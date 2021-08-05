using Domain.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mapping
{
    public class ProdutoMap : ClassMap<Produto>
    {
        public ProdutoMap()
        {
            Table("Produto");

            Id(x => x.ProdutoId).GeneratedBy.Identity().UnsavedValue(0);

            Map(x => x.Nome).Length(50).Not.Nullable();
            Map(x => x.Descricao).Length(150);
            Map(x => x.Valor);
        }
    }
}
