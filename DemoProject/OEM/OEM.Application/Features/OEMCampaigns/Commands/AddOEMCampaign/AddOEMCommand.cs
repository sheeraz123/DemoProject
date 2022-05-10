
using MediatR;
using OEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Application.Features.OEMCampaigns.Commands.AddOEMCampaign
{
    public class AddOEMCommand :IRequest<decimal>
    {
        public string ListTitle { get; set; }

        public string RegionId { get; set; }
        public AddOEMImage images { get; set; }
    }
}
