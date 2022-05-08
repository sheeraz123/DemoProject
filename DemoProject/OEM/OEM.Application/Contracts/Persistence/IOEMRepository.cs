using OEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Application.Contracts.Persistence
{
    public interface IOEMRepository : IAsyncRepository<OEMCampaign>
    {
        Task<IEnumerable<OEMCampaign>> GetOEMCampaigns(string regionId);
    }
}
