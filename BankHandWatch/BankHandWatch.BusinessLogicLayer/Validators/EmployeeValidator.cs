using BankHandWatch.DataAccessLayer.Domains;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Validators
{
    public class EmployeeValidator: AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {

            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(3);

            RuleFor(x => x.LastName).NotEmpty().MinimumLength(3);

            RuleFor(x => x.TC).NotEmpty().Length(11);

            RuleFor(x => x.Phone).NotEmpty().MinimumLength(11);

            RuleFor(x => x.Gender).NotEmpty().Length(1);

            RuleFor(x => x.Birthdate).NotEmpty();

            RuleFor(x => x.BranchId).NotEmpty();

            RuleFor(x => x.Salary).NotEmpty().GreaterThanOrEqualTo(1);

            RuleFor(x => x.WorkingTime).NotEmpty();
        }
    }
}
