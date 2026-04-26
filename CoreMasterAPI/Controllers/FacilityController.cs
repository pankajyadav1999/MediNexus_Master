using Microsoft.AspNetCore.Mvc;
using CoreBussiness.IManager;
using CoreModel.DTOs.Facility;

namespace CoreMasterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        private readonly IFacilityManager _manager;

        public FacilityController(IFacilityManager manager)
        {
            _manager = manager;
        }

        [HttpPost("AddFacility")]
        public async Task<IActionResult> AddFacility(AddFacilityDTO dto)
        {
            var result = await _manager.AddFacility(dto);
            return Ok(result);
        }
    }
}