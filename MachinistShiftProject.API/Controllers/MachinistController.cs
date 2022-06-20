using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.Business.Concrate;
using MachinistShiftProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MachinistShiftProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinistController : ControllerBase
    {
        private IMachinistService _machinistShiftService;
        public MachinistController(IMachinistService machinistShiftService)
        {
            _machinistShiftService = machinistShiftService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_machinistShiftService.GetAll());

        }
        [HttpGet("{id}")]
        public async Task<Machinist> Get(int id)
        {
            return await _machinistShiftService.GetById(id);

        }
        [HttpPost]
        public async Task<Machinist> Post([FromBody] Machinist machinist)
        {
            return await _machinistShiftService.Create(machinist);

        }
        [HttpPut]
        public async Task<Machinist> Put([FromBody] Machinist machinist)
        {
            return await _machinistShiftService.Update(machinist);

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _machinistShiftService.Delete(id);

        }
    }
}
