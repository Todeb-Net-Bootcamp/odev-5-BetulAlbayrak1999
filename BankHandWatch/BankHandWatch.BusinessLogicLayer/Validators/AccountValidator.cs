using BankHandWatch.DataAccessLayer.Domains;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Validators
{
    public class AccountValidator: AbstractValidator<Account>
    {
        public AccountValidator()
        {
            RuleFor(x => x.Iban).NotNull().Length(26);

            RuleFor(x => x.AccountNo).NotNull().Length(12);

           // RuleFor(x => x.CustomerId).NotNull();

            RuleFor(x => x.CurrentBalance).GreaterThanOrEqualTo(0);

        }
    }
}
