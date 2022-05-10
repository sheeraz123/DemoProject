using OEM.Application.Contracts.Persistence;
using OEM.Domain.Entities;
using OEM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Infrastructure.Repositories
{
    public class OEMCampaignRepository : RepositoryBase<OEMCampaign>, IOEMRepository
    {
        public OEMCampaignRepository(OEMContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<OEMCampaign>> GetOEMCampaigns(string regionId)
        {
            var oemCampaignist = await _dbContext.OEMCampaigns.Where(a => a.RegionId == regionId).ToListAsync();
            return oemCampaignist;
        }
    }
}

