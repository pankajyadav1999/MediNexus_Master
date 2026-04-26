using CoreData.DbContexts;
using CoreData.IRepository;

namespace CoreData.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MasterDbContext _context;

        public IFacilityRepository FacilityRepository { get; }

        public UnitOfWork(
            MasterDbContext context,
            IFacilityRepository facilityRepository)
        {
            _context = context;
            FacilityRepository = facilityRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}