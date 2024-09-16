using FlexEmulation.Dtos.Section;
using FlexEmulation.Interfaces;
using FlexEmulation.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace FlexEmulation.Controllers
{
    [Route("FlexEmulation/section")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionRepository _sectionRepo;
        public SectionController(ISectionRepository sectionRepo)
        {
            _sectionRepo = sectionRepo;
        }

        [HttpGet]
        [Route("sections")]
        public async Task<IActionResult> GetAll()
        {
            var sections = await _sectionRepo.GetAllAsync();
            return Ok(sections.Select(s => s.ToSectionDto()));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSectionDto sectionDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdSection = await _sectionRepo.CreateAsync(sectionDto.ToSectionModelFromCreateDto());
            return Ok(createdSection.ToSectionDto());
        }
    }
}
