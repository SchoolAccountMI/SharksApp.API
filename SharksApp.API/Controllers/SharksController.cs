using Microsoft.AspNetCore.Mvc;
using SharksApp.API.Dtos;
using SharksApp.API.Services;

namespace SharksApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SharksController : ControllerBase
    {
        private readonly ISharksService _service;

        public SharksController(ISharksService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var shark = _service.GetById(id);
            if (shark == null) return NotFound();
            return Ok(shark);
        }

        [HttpPost]
        public IActionResult Create(SharkRequestDto dto)
        {
            _service.Create(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
