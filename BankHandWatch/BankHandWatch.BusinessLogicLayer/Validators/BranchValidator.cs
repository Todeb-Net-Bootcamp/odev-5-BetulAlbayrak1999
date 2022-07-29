using BankHandWatch.DataAccessLayer.Domains;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Validators
{
    public class BranchValidator: AbstractValidator<Branch>
    {
        public BranchValidator()
        {
            RuleFor(x=> x.BankId).NotNull().NotEmpty();

            RuleFor(x=> x.LocationId).NotNull().NotEmpty();
        }
    }
}
