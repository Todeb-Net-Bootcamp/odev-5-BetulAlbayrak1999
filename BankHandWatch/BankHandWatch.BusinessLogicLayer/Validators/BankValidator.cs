using BankHandWatch.DataAccessLayer.Domains;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Validators
{
    public class BankValidator : AbstractValidator<Bank>
    {
        public BankValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3);
        }
    }
}
