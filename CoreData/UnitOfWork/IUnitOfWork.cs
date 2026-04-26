using CoreData.IRepository;

namespace CoreData.UnitOfWork
{
    public interface IUnitOfWork
    {
        IFacilityRepository FacilityRepository { get; }
        Task<int> SaveChangesAsync();
    }
}