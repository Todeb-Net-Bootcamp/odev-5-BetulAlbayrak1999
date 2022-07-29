using BankHandWatch.BusinessLogicLayer.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Validators.Customers
{
    public class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
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
