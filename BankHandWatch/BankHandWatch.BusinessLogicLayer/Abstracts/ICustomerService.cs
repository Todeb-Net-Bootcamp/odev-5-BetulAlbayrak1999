using BankHandWatch.BusinessLogicLayer.Dtos;
using BankHandWatch.BusinessLogicLayer.ViewModels.Customers;
using BankHandWatch.DataAccessLayer.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Abstracts
{
    public interface ICustomerService : IGenericService<CreateCustomerRequest, UpdateCustomerRequest, GetAllCustomerViewModel, GetByIdCustomerViewModel>
    {
    }
}