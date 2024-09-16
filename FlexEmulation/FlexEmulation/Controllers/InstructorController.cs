using FlexEmulation.Dtos.Instructor;
using FlexEmulation.Interfaces;
using FlexEmulation.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace FlexEmulation.Controllers
{
    [Route("FlexEmulation/instructor")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorRepository _instructorRepo;
        private readonly IBranchRepository _branchRepo;

        public InstructorController(IInstructorRepository instructorRepo,
            IBranchRepository branchRepo)
        {
            _instructorRepo = instructorRepo;
            _branchRepo = branchRepo;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateInstructorDto instructorDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var instructorModel = instructorDto.ToInstructorModelFromCreateDto();
            var savedInstructorModel = await _instructorRepo.CreateAsync(instructorModel);

            return Ok(savedInstructorModel);
        }

        [HttpPut]
        [Route("{id}/assign-branch")]
        public async Task<IActionResult> AssignBranch(int id, int branchId)
        {
            var instructorModel = await _instructorRepo.GetByIdAsync(id);

            if (instructorModel == null)
                return NotFound("Instructor not found");

            var branchModel = await _branchRepo.GetByIdAsync(branchId);

            if (branchModel == null)
                return NotFound("Branch not found");

            var savedInstructorModel = await _instructorRepo.AssignBranchAsync(instructorModel, branchModel);
            return Ok(savedInstructorModel.ToInstructorDto());
        }
    }
}
