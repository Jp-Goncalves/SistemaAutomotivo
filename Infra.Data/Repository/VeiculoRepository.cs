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
    public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(NHibernateHelper helper) : base(helper)
        {
        }

        public async Task<Veiculo> SelectByPlacaAsync(string placa)
        {
            return await _session.Query<Veiculo>().Where(v => v.Placa.Contains(placa)).FirstOrDefaultAsync();
        }
    }
}
