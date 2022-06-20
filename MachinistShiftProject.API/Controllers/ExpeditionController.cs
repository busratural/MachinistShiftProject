using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MachinistShiftProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpeditionController : ControllerBase
    {
        private IExpeditionService _expeditionService;
        public ExpeditionController(IExpeditionService expeditionService)
        {
            _expeditionService = expeditionService;
        }
        [HttpGet]
        public  IActionResult Get()
        {
            return  Ok(_expeditionService.GetAll());

        }
        [HttpGet("{id}")]
        public async Task<Expedition> Get(int id)
        {
            return await _expeditionService.GetById(id);

        }
        [HttpPost]
        public async Task<Expedition> Post([FromBody] Expedition expedition)
        {
            return await _expeditionService.Create(expedition);

        }
        [HttpPut]
        public async Task<Expedition> Put([FromBody] Expedition expedition)
        {
            return await _expeditionService.Update(expedition);

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _expeditionService.Delete(id);

        }
    }
}
