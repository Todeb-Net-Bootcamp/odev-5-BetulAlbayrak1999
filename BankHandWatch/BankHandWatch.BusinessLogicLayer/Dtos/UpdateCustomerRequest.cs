using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.BusinessLogicLayer.Dtos
{
    public class UpdateCustomerRequest
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TC { get; set; }

        public string Phone { get; set; }

        public string Gender { get; set; }

        public DateTime? Birthdate { get; set; }

        public string ImagePath { get; set; }

        public string Password { get; set; }
    }
}
