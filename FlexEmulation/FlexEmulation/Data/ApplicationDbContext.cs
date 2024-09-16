using FlexEmulation.Models;
using Microsoft.EntityFrameworkCore;

namespace FlexEmulation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet for each entity
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Branch> Branches { get; set; }

        // DbSet for each join table
        public DbSet<SectionCourse> SectionCourses { get; set; }
        public DbSet<SectionCourseInstructor> SectionCourseInstructors { get; set; }
        public DbSet<SectionStudentCourse> SectionStudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // SectionCourse (Many-to-Many between Course and Section)
            modelBuilder.Entity<SectionCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.SectionCourses)
                .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<SectionCourse>()
                .HasOne(sc => sc.Section)
                .WithMany(s => s.SectionCourses)
                .HasForeignKey(sc => sc.SectionId);

            // SectionCourseInstructor (Many-to-Many between Instructor and SectionCourse)
            modelBuilder.Entity<SectionCourseInstructor>()
                .HasOne(sci => sci.Instructor)
                .WithMany(i => i.SectionCourseInstructors)
                .HasForeignKey(sci => sci.InstructorId);

            modelBuilder.Entity<SectionCourseInstructor>()
                .HasOne(sci => sci.SectionCourse)
                .WithMany(sc => sc.SectionCourseInstructors)
                .HasForeignKey(sci => sci.SectionCourseId);

            // SectionStudentCourse (Many-to-Many between Student and SectionCourse)
            modelBuilder.Entity<SectionStudentCourse>()
                .HasOne(ssc => ssc.Student)
                .WithMany(s => s.SectionStudentCourses)
                .HasForeignKey(ssc => ssc.StudentId);

            modelBuilder.Entity<SectionStudentCourse>()
                .HasOne(ssc => ssc.SectionCourse)
                .WithMany(sc => sc.SectionStudentCourses)
                .HasForeignKey(ssc => ssc.SectionCourseId);
        }
    }
}
