using BankHandWatch.BusinessLogicLayer.Abstracts;
using BankHandWatch.BusinessLogicLayer.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BankHandWatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult>  GetAllUnActive()
        {
            try
            {
                var customers =await _customerService.GetAllUnActive();
                return Ok(customers);
            }
            catch(Exception ex) { return null; }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllActive()
        {
            try
            {
                var customers = await _customerService.GetAllActive();
                return Ok(customers);
            }
            catch (Exception ex) { return null; }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerRequest model)
        {
            try
            {
                var customer = await _customerService.Create(model);
                return Ok(customer);
            }
            catch (Exception ex) { return null; }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCustomerRequest model)
        {
            try
            {
                var customer = await _customerService.Update(model);
                return Ok(customer);
            }
            catch (Exception ex) { return null; }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var customer = await _customerService.Delete(Id);
                return Ok(customer);
            }
            catch (Exception ex) { return null; }
        }
    }
}