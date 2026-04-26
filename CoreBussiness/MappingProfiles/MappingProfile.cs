using AutoMapper;
using CoreModel.DTOs.Facility;
using CoreModel.Entities.Facility;

namespace CoreBussiness.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddFacilityDTO, FacilityMaster>().ReverseMap();
        }
    }
}