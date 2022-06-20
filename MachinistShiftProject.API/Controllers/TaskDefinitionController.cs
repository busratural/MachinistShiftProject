using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MachinistShiftProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskDefinitionController : ControllerBase
    {

        private ITaskDefinitonService _taskDefinitonService;
        public TaskDefinitionController(ITaskDefinitonService taskDefinitonService)
        {
            _taskDefinitonService = taskDefinitonService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_taskDefinitonService.GetAll());

        }
        [HttpGet("{id}")]
        public async Task<TaskDefinition> Get(int id)
        {
            return await _taskDefinitonService.GetById(id);

        }
        [HttpPost]
        public async Task<TaskDefinition> Post([FromBody] TaskDefinition expedition)
        {
            return await _taskDefinitonService.Create(expedition);

        }
        [HttpPut]
        public async Task<TaskDefinition> Put([FromBody] TaskDefinition expedition)
        {
            return  await _taskDefinitonService.Update(expedition);

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _taskDefinitonService.Delete(id);

        }
    }
}
