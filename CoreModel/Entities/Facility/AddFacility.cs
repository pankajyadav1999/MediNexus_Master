using System.ComponentModel.DataAnnotations.Schema;
using CoreModel.Entities.Base;

namespace CoreModel.Entities.Facility
{
    [Table("FacilityMaster")]
    public class FacilityMaster : BaseEntity
    {
        public string FacilityName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? RoleId { get; set; }
    }
}