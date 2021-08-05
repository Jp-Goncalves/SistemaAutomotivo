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
    public class MarcaRepository : Repository<Marca>, IMarcaRepository
    {
        public MarcaRepository(NHibernateHelper helper) : base(helper)
        {
        }
    }
}
