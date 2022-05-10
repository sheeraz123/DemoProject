using Microsoft.EntityFrameworkCore;
using OEM.Domain.Common;
using OEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Infrastructure.Persistence
{
    public class OEMContext : DbContext
    {
        public OEMContext(DbContextOptions<OEMContext> options) : base(options)
        {

        }

        public DbSet<OEMCampaign> OEMCampaigns { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedOn = DateTime.Now;
                        entry.Entity.CreatedBy = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.updatedOn = DateTime.Now;
                        entry.Entity.UpdatedBy = 2;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
