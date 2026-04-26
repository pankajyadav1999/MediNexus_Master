namespace CoreModel.DTOs.Facility
{
    public class AddFacilityDTO
    {
        public int EnterpriseId { get; set; }
        public int FacilityId { get; set; }
        public string FacilityName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string EnteredBy { get; set; } = string.Empty;
    }
}