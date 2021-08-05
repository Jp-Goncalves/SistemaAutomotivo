using Domain.Interface.Repository;
using Domain.Model;
using Infra.Data.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(NHibernateHelper helper) : base(helper)
        {
        }
    }
}
