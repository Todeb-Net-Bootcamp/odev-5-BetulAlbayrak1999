using BankHandWatch.DataAccessLayer.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Abstracts
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
    }
}
