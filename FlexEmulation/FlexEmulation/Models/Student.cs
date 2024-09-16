using FlexEmulation.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int RollNo { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    // Navigation properties
    public ICollection<SectionStudentCourse> SectionStudentCourses { get; set; } = new List<SectionStudentCourse>();
}