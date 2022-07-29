using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains.SysDomains
{
    public class City: BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
