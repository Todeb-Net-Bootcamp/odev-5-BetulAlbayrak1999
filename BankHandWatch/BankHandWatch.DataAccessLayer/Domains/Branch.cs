using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Branch : BaseEntity
    {
        public int BankId { get; set; }

        [ForeignKey(nameof(BankId))]
        public virtual Bank Bank { get; set; }

        public int LocationId { get; set; }
        [ForeignKey(nameof(LocationId))]
        public virtual Location Location { get; set; }

        /*public virtual ICollection<Customer> Customers { get; set; }*/
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
