using FluentValidation;
using BankHandWatch.DataAccessLayer.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankHandWatch.BusinessLogicLayer.Dtos;

namespace BankHandWatch.BusinessLogicLayer.Validators.Customers
{
    public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(3);

            RuleFor(x => x.LastName).NotEmpty().MinimumLength(3);

            RuleFor(x => x.TC).NotEmpty().Length(11);

            RuleFor(x => x.Phone).NotEmpty().MinimumLength(11);

            RuleFor(x => x.Gender).NotEmpty().Length(1);

            RuleFor(x => x.Birthdate).NotEmpty();

            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
        }
    }
}
