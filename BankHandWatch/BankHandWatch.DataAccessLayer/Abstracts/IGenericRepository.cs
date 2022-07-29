using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Abstracts
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<bool> Create(T item);

        public Task<bool> Delete(T item);

        public Task<bool> Update(T item);

        public Task<IEnumerable<T>> GetAll();

        public Task<T> GetById(int Id);
    }
}
