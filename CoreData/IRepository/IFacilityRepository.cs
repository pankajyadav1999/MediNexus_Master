using CoreModel.Entities.Facility;

namespace CoreData.IRepository
{
    public interface IFacilityRepository
    {
        void AddFacility(FacilityMaster facility);
    }
}