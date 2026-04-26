using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreModel.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EnterpriseId { get; set; }

        [Required]
        public int FacilityId { get; set; }

        public string? EnteredBy { get; set; }
        public string? ModifiedBy { get; set; }

        public DateTime FromDate { get; set; } = DateTime.UtcNow;
        public DateTime? ToDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
