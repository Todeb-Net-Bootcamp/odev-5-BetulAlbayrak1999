using BankHandWatch.DataAccessLayer.Domains;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Validators
{
    public class WatchValidator : AbstractValidator<Watch>
    {
        public WatchValidator()
        {
            RuleFor(x => x.Color).NotEmpty().MinimumLength(3);

           // RuleFor(x => x.CustomerId).NotEmpty();

            RuleFor(x => x.ExpireTime).NotNull().Must(ValidDate).WithMessage("Date is Expire"); ;
        }

        private bool ValidDate(DateTime date)
        {
            DateTime currentDate = DateTime.Now;
            if(date <= currentDate)
                return false;
            return true;
        }
    }
}