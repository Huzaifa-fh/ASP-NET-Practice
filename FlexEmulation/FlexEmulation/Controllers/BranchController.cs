using FlexEmulation.Dtos.Branch;
using FlexEmulation.Interfaces;
using FlexEmulation.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace FlexEmulation.Controllers
{
    [Route("FlexEmulation/Branch")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchRepository _branchRepo;
        public BranchController(IBranchRepository branchRepo)
        {
            _branchRepo = branchRepo;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBranchDto branchDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var branchModel = branchDto.ToBranchModelFromBranchDto();
            var savedbranchModel = await _branchRepo.CreateAsync(branchModel);

            return Ok(savedbranchModel); 
        }

        [HttpGet]
        [Route("branches")]
        public async Task<IActionResult> GetAllBranches()
        {
            var branches = await _branchRepo.GetAllAsync();
            return Ok(branches.Select(branch => branch.ToBranchDto()));
        }
    }
}
