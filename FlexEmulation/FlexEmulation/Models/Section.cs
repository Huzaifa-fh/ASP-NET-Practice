using FlexEmulation.Models;

public class Section
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    // Navigation properties
    public ICollection<SectionCourse> SectionCourses { get; set; } = new List<SectionCourse>();
    public ICollection<SectionCourseInstructor> SectionCourseInstructor { get; set; } = new List<SectionCourseInstructor>();
}