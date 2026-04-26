using CoreModel.Entities.Base;

namespace CoreModel.Entities.Facility
{
    public class FacilityMaster : BaseEntity
    {
        public string FacilityName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}