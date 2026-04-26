using CoreModel.Entities.Facility;
using Microsoft.EntityFrameworkCore;

namespace CoreData.DbContexts
{
    public class MasterDbContext : DbContext
    {
        public MasterDbContext(DbContextOptions<MasterDbContext> options)
            : base(options)
        {
        }

        public DbSet<FacilityMaster> FacilityMasters { get; set; }
    }
}