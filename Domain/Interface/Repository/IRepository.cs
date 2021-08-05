using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository
{
    public interface IRepository<T> where T : class
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        void SaveOrUpdate(T obj);

        T SelectById(int id);

        IList<T> SelectAll();

        void Disposed();

        Task<IList<T>> SelectAllAsync();

        Task<T> SelectByIdAsync(int id);
    }
}
