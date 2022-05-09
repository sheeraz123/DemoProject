using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Application.Features.OEMCampaigns.Commands.AddOEMCampaign
{
    public class AddOEMCommand
    {
        public string ListTitle { get; set; }
        public AddOEMImage images { get; set; }
    }
}
