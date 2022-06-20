using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MachinistShiftProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitleController : ControllerBase
    {
  
        private ITitleService _titleService;
        public TitleController(ITitleService titleService)
        {
            _titleService = titleService;
        }

        [HttpGet]
        public ActionResult<List<Title>> Get()
        {
            return Ok(_titleService.GetAll());
        }


        [HttpGet("{id}")]
        public async Task<Title> Get(int id)
        {
            return await _titleService.GetById(id);

        }
        [HttpPost]
        public async Task<Title> Post([FromBody] Title title)
        {
            return await _titleService.Create(title);

        }
        [HttpPut]
        public async Task<Title> Put([FromBody] Title title)
        {
            return await _titleService.Update(title);

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _titleService.Delete(id);

        }

    }

}
