using FlexEmulation.Dtos.Student;
using FlexEmulation.Interfaces;
using FlexEmulation.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace FlexEmulation.Controllers
{
    [Route("FlexEmulation/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepo;
        public StudentController(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var studentModel = await _studentRepo.GetByIdAsync(id);

            if (studentModel == null)
                return NotFound();

            return Ok(studentModel.ToStudentDto());
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var studentModel = studentDto.ToStudentModelFromCreateDto();
            var savedStudentModel = await _studentRepo.CreateAsync(studentModel);

            return CreatedAtAction(nameof(GetById), new { id = studentModel.Id }, studentModel.ToStudentDto());
        }
    }
}
