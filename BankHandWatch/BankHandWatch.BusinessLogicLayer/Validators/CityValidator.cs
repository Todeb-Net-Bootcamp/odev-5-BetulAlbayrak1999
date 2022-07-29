using BankHandWatch.DataAccessLayer.Domains.SysDomains;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Validators
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(x=> x.Name).NotEmpty().MinimumLength(3);
        }
    }
}
