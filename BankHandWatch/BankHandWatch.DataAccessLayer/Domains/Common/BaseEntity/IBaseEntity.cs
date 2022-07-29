using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity
{
    public interface IBaseEntity
    {

        [ScaffoldColumn(false)]
        [Column(TypeName = "DateTime2")]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false), Column(TypeName = "DateTime2")]
        public DateTime LastModifiedDate { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "DateTime2")]
        public DateTime? UnActiveDate { get; set; }

        [ScaffoldColumn(false)]
        public bool IsActive { get; set; }
    }
}
