using OEM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Domain.Entities
{
    public class OEMCampaign : EntityBase
    {
        public string ListTitle { get; set; }
        public OEMImages images { get; set; }

    }
}
