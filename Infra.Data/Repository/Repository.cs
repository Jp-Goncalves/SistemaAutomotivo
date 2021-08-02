using Domain.Interface;
using Domain.Interface.Repository;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly ISession _session;
        protected readonly ITransaction _transaction;

        public Repository(Helper.NHibernateHelper helper)
        {
            _session = helper.OpenSession();
            _transaction = _session.BeginTransaction();
        }

        public void Delete(int id)
        {
            _session.Delete(id);
            _transaction.Commit();
        }

        public void Disposed()
        {
            _transaction.Dispose();
        }

        public void Insert(T obj)
        {
            _session.Save(obj);
            _transaction.Commit();
        }

        public void SaveOrUpdate(T obj)
        {
            _session.SaveOrUpdate(obj);
            _transaction.Commit();
        }

        public IList<T> SelectAll()
        {
            return _session.Query<T>().ToList();
        }

        public async Task<IList<T>> SelectAllAsync()
        {
            return await _session.Query<T>().ToListAsync();
        }

        public T SelectById(int id)
        {
            return _session.Query<T>().FirstOrDefault();
        }

        public Task<T> SelectByIdAsync(int id)
        {
            return _session.GetAsync<T>(id);
        }

        public void Update(T obj)
        {
            _session.Update(obj);
            _transaction.Commit();
        }
    }
}
