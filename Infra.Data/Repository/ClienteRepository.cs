using Domain.Interface.Repository;
using Domain.Model;
using Infra.Data.Helper;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(NHibernateHelper helper) : base(helper)
        {
        }

        public async Task<Cliente> SelectByNomeAsync(string nome)
        {
            return await _session.Query<Cliente>().Where(c => c.Nome.Contains(nome)).FirstOrDefaultAsync();
        }
    }
}
