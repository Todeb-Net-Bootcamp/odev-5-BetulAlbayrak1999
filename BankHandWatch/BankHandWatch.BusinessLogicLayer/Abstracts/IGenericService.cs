using BankHandWatch.BusinessLogicLayer.Configrations.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Abstracts
{
    public interface IGenericService<TCreate, TUpdate, TGetAll, TGetById> 
        where TCreate : class, new()
        where TUpdate : class, new()
        where TGetAll : class, new()
        where TGetById : class, new()
    {
        public Task<CommandResponse> Create(TCreate item);

        public Task<CommandResponse> Delete(int Id);

        public Task<CommandResponse> Update(TUpdate item);

        public Task<IEnumerable<TGetAll>> GetAllUnActive();
        public Task<IEnumerable<TGetAll>> GetAllActive();

        public Task<TGetById> GetById(int Id);
    }
}
