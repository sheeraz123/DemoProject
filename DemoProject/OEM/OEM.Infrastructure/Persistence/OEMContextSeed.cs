using Microsoft.Extensions.Logging;
using OEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Infrastructure.Persistence
{
    public class OEMContextSeed
    {
        public static async Task SeedAsync(OEMContext oemContext, ILogger<OEMContextSeed> logger)
        {
            if (!oemContext.OEMCampaigns.Any())
            {
                oemContext.OEMCampaigns.AddRange();
                await oemContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OEMContext).Name);
            }
        }
        private static IEnumerable<OEMCampaign> GetOEMCampaignDetails()
        {
            return new List<OEMCampaign>
            {
                new OEMCampaign() {ListTitle="BMW X5", images={ListImage="Image1"}}
            };
        }

    }
}


