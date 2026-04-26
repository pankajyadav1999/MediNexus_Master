using CoreModel.DTOs.Facility;

namespace CoreBussiness.IManager
{
    public interface IFacilityManager
    {
        Task<string> AddFacility(AddFacilityDTO dto);
    }
}