using FlexEmulation.Dtos.Course;
using FlexEmulation.Models;

namespace FlexEmulation.Mappers
{
    public static class CourseMappers
    {
        public static CourseDto ToCourseDto(this Course courseModel)
        {
            return new CourseDto
            {
                Name = courseModel.Name,
                Code = courseModel.Code,
            };
        }

        public static Course ToCourseModelFromCreateCourseDto(this CreateCourseDto courseDto)
        {
            return new Course
            {
                Name = courseDto.Name,
                Code = courseDto.Code,
            };
        }
    }
}
