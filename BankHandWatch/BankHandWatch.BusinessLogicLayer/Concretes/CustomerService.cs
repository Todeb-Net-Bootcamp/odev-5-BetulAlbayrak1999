using AutoMapper;
using BankHandWatch.BusinessLogicLayer.Abstracts;
using BankHandWatch.BusinessLogicLayer.Configrations.Extensions;
using BankHandWatch.BusinessLogicLayer.Configrations.Response;
using BankHandWatch.BusinessLogicLayer.Dtos;
using BankHandWatch.BusinessLogicLayer.Validators.Customers;
using BankHandWatch.BusinessLogicLayer.ViewModels.Customers;
using BankHandWatch.DataAccessLayer.Abstracts;
using BankHandWatch.DataAccessLayer.Domains;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Concretes
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _autoMapper;
        public CustomerService(ICustomerRepository customerRepository, IMapper autoMapper)
        {
            _customerRepository = customerRepository;
            _autoMapper = autoMapper;   
        }
        public async Task<CommandResponse> Create(CreateCustomerRequest item)
        {
            try
            {
                if (item is not null)
                {
                    //validation
                    var validator = new CreateCustomerRequestValidator();
                    validator.Validate(item).throwIfValidationException();
                    
                    //mapping
                    Customer customer = _autoMapper.Map<Customer>(item);
                    await _customerRepository.Create(customer);
                    return new CommandResponse { Status = true, Message = "This operation has done successfully" };
                }

                { return new CommandResponse { Status = false, Message = "This operation has not done successfully" }; }

            }
            catch (Exception ex) { return new CommandResponse { Status = false, Message = "This operation has not done successfully" }; }
        }

        public async Task<CommandResponse> Delete(int Id)
        {
            try
            {
                if(Id > 0)
                {
                    Customer customer = await _customerRepository.GetById(Id);
                    if(customer != null)
                    {
                        customer.IsActive = false;
                        await _customerRepository.Update(customer);

                        return new CommandResponse { Status = true, Message = "This operation has not done successfully" };
                    }

                    { return new CommandResponse { Status = false, Message = "This operation has not done successfully" }; }
                }
                { return new CommandResponse { Status = false, Message = "This operation has not done successfully" }; }
            }
            catch (Exception ex) { return new CommandResponse { Status = false, Message = "This operation has not done successfully" }; }
        }

        public async Task<CommandResponse> Update(UpdateCustomerRequest item)
        {
            try
            {
                if (item is not null || GetById(item.Id) is not null)
                {
                    //validation
                    var validator = new UpdateCustomerRequestValidator();
                    validator.Validate(item).throwIfValidationException();

                //mapping
                Customer customer = _autoMapper.Map<Customer>(item);

                    await _customerRepository.Update(customer);
                    return new CommandResponse { Status = true, Message = "This operation has done successfully" };
                }

                { return new CommandResponse { Status = false, Message = "This operation has not done successfully" }; }

            }
            catch (Exception ex) { return new CommandResponse { Status = false, Message = "This operation has not done successfully" }; }
        }

        public async Task<IEnumerable<GetAllCustomerViewModel>> GetAllActive()
        {
            try
            {
                IEnumerable<Customer> customers = await _customerRepository.GetAll();

                IEnumerable<GetAllCustomerViewModel> result = customers.Where(d => d.IsActive == true).Select(d => new GetAllCustomerViewModel
                {
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    Phone = d.Phone,
                    Gender = d.Gender,
                    ImagePath = d.ImagePath
                });
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<IEnumerable<GetAllCustomerViewModel>> GetAllUnActive()
        {
            try
            {
                IEnumerable<Customer> customers = await _customerRepository.GetAll();

                IEnumerable<GetAllCustomerViewModel> result = customers.Where(d => d.IsActive == false).Select(d => new GetAllCustomerViewModel
                {
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    Phone = d.Phone,
                    Gender = d.Gender,
                    ImagePath = d.ImagePath
                });
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }



        public async Task<GetByIdCustomerViewModel> GetById(int Id)
        {
            try
            {
                if (Id > 0)
                {
                    Customer customer = await _customerRepository.GetById(Id);
                    if(customer is not null)
                    {
                        //mapping
                        GetByIdCustomerViewModel mappedCustomer =  _autoMapper.Map<GetByIdCustomerViewModel>(customer);

                        return mappedCustomer;
                    }
                    return null;
                }

                { return null; }

            }
            catch (Exception ex) { return null; }
        }
    }
}
