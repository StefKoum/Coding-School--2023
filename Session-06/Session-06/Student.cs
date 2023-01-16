using System;

public class Student : Person
{
    //Properties
    public int RegistrationNumber { get; set; }
    public Course[]? Courses { get; set; }

    //Methods
    public void Attend(Course[] course, DateTime datetime)
    {
    }

    public void WriteExam(Course[] course, DateTime datetime)
    {
    }
}
