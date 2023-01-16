using System;

public class University : Institute
{
    //Properties
    public Student[]? Students { get; set; }
    public Course[]? Courses { get; set; }
    public Grade[]? Grades { get; set; }
    public Schedule[]? ScheduledCourse { get; set; }

    //Methods
    public void GetStudents()
    {
    }

    public void GetCourses()
    {
    }

    public void GetGrades()
    {
    }

    public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime datetime)
    {
    }
}
