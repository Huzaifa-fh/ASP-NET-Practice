using FlexEmulation.Dtos.Course;
using FlexEmulation.Helpers.SectionQueryObjects;
using FlexEmulation.Interfaces;
using FlexEmulation.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace FlexEmulation.Controllers
{
    [Route("course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepo;
        private readonly ISectionRepository _sectionRepo;
        public CourseController(ICourseRepository courseRepo,
            ISectionRepository sectionRepo)
        {
            _courseRepo = courseRepo;
            _sectionRepo = sectionRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var courses = await _courseRepo.GetAllAsync();
            return Ok(courses.Select(c => c.ToCourseDto()));
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCourseDto courseDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var savedCourse = await _courseRepo.CreateAsync(courseDto.ToCourseModelFromCreateCourseDto());
            return Ok(savedCourse.ToCourseDto());
        }

        //[HttpPut]
        //[Route("assign-section-to-course")]
        //public async Task<IActionResult> AssignSectionToCourse([FromBody] AssignSectionToCourseQueryObject queryObject)
        //{
        //    var sectionModel = _sectionRepo.GetByIdAsync(queryObject.SectionId);

        //    if (sectionModel == null)
        //        return NotFound("Section does not exist");

        //    var courseModel = _courseRepo.GetByIdAsync(queryObject.CourseId);

        //    if (courseModel == null)
        //        return NotFound("Course does not exist");

        //    var savedSectionCourseModel = _courseRepo.AddAsync(sectionModel, courseModel);

        //    return Ok(savedSectionCourseModel.ToDto());
        //}
        
    }
}
