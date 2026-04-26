using CoreData.DbContexts;
using CoreData.IRepository;
using CoreModel.Entities.Facility;

namespace CoreData.Repositories
{
    public class FacilityRepository : IFacilityRepository
    {
        private readonly MasterDbContext _context;

        public FacilityRepository(MasterDbContext context)
        {
            _context = context;
        }

        public void AddFacility(FacilityMaster facility)
        {
            _context.FacilityMasters.Add(facility);
            _context.SaveChanges();
        }
    }
}