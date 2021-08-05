using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Helper
{
    public class NHibernateHelper
    {
        public ISession OpenSession()
        {
            var connectioString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SistemaAutomotivo;Integrated Security=True; User Id=userdb;Password=1234;";

            ISessionFactory sessionFactory = Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2012
                        .ConnectionString(connectioString))
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>())
                        .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true))
                        .ExposeConfiguration(c => c.SetProperty(NHibernate.Cfg.Environment.GenerateStatistics, "true"))
                        .ExposeConfiguration(c => c.SetProperty(NHibernate.Cfg.Environment.CurrentSessionContextClass, "web"))
                        .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
