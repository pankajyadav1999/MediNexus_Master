using AutoMapper;
using CoreBussiness.IManager;
using CoreData.IRepository;
using CoreModel.DTOs.Facility;
using CoreModel.Entities.Facility;

namespace CoreBussiness.Managers
{
    public class FacilityManager : IFacilityManager
    {
        private readonly IFacilityRepository _repository;
        private readonly IMapper _mapper;

        public FacilityManager(
            IFacilityRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string> AddFacility(AddFacilityDTO dto)
        {
            var facility = _mapper.Map<FacilityMaster>(dto);

            _repository.AddFacility(facility);

            return "Facility Added Successfully";
        }
    }
}