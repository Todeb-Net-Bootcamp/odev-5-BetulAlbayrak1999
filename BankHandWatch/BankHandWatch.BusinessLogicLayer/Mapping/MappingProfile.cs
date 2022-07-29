using AutoMapper;
using BankHandWatch.BusinessLogicLayer.Dtos;
using BankHandWatch.BusinessLogicLayer.ViewModels.Customers;
using BankHandWatch.DataAccessLayer.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCustomerRequest, Customer>().ReverseMap();
            CreateMap<UpdateCustomerRequest, Customer>().ReverseMap();
            CreateMap<GetByIdCustomerViewModel, Customer>().ReverseMap();
        }
    }
}
