using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Application.Features.OEMCampaigns.Queries.GetOEMCompaign
{
    public class GetOEMCampaignListQuery : IRequest<List<OEMCampaignVM>>
    {
        public readonly string RegionId;

        public GetOEMCampaignListQuery(string regionId)
        {
            this.RegionId = regionId ?? throw new ArgumentNullException(nameof(regionId));
        }
    }
}
