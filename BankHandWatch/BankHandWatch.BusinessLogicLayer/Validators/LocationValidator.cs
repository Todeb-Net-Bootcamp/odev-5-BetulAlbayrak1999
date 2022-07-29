using BankHandWatch.DataAccessLayer.Domains;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Validators
{
    public class LocationValidator : AbstractValidator<Location>
    {
        public LocationValidator()
        {
            RuleFor(x => x.CityId).NotEmpty();

            RuleFor(x => x.Street).NotEmpty().MinimumLength(3);

            RuleFor(x => x.PostalCode).NotEmpty().Length(5);
        }
    }
}