using FlexEmulation.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;

    // Navigation properties
    public ICollection<SectionCourse> SectionCourses { get; set; } = new List<SectionCourse>();
    public ICollection<SectionCourseInstructor> SectionCourseInstructors { get; set; } = new List<SectionCourseInstructor>();
}