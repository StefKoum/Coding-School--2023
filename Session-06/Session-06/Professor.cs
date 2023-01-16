using System;

public class Professor : Person
{
    public string? Rank { get; set; }
    public string? Name { get; set; }
    public Course Course { get; set; }

    //Methods
    public void GetName()
    {
    }

    public void Teach(Course[] course, DateTime datetime)
    {
    }

    public void SetGrade(Guid studentID, Guid courseID, int grade)
    {
    }
}
