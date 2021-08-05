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
    public class ServicoRepository : Repository<Servico>, IServicoRepository
    {
        public ServicoRepository(NHibernateHelper helper) : base(helper)
        {
        }
    }
}
