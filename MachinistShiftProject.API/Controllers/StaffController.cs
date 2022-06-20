using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MachinistShiftProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public ActionResult<List<Staff>> Get()
        {
            return Ok(_staffService.GetAll());
        }


        [HttpGet("{id}")]
        public async Task<Staff> Get(int id)
        {
            return await _staffService.GetById(id);

        }  

        [HttpPost]
        public async Task<Staff> Post([FromBody] Staff staff)
        {
            return await _staffService.Create(staff);

        }
        [HttpPut]
        public async Task<Staff> Put([FromBody] Staff staff)
        {
            return await _staffService.Update(staff);

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _staffService.Delete(id);

        }
    }
}
