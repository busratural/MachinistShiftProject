using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MachinistShiftProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskTitleController : ControllerBase
    {
        private ITaskTitleService _taskTitleService;

        public TaskTitleController(ITaskTitleService taskTitleServic)
        {
            _taskTitleService=taskTitleServic;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_taskTitleService.GetAll());

        }
        [HttpGet("{id}")]
        public  async Task<TaskTitle> Get(int id)
        {
            return await _taskTitleService.GetById(id);

        }
        [HttpPost]
        public async Task<TaskTitle> Post([FromBody] TaskTitle expedition)
        {
            return await _taskTitleService.Create(expedition);

        }
        [HttpPut]
        public async Task<TaskTitle> Put([FromBody] TaskTitle expedition)
        {
            return await _taskTitleService.Update(expedition);

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _taskTitleService.Delete(id);

        }
    }
}
