using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Domain.Common
{
    public abstract class EntityBase
    {
        public decimal Id { get; set; }
        public decimal CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public decimal UpdatedBy { get; set; }
        public DateTime? updatedOn { get; set; }


    }
}
