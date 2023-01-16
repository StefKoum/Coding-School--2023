using System;

public class Professor : Person
{
    public string? Rank { get; set; }
    public string? Name { get; set; }
    public Course[]? Courses { get; set; }

    //Methods
    public void GetName()
    {
    }

    public void Teach(Course[] courses, DateTime datetime)
    {
    }

    public void SetGrade(Guid studentID, Guid courseID, int grade)
    {
    }
}
