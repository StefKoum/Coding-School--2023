using System;

public class Student : Person
{
    //Properties
    public int RegistrationNumber { get; set; }
    public Course[]? Courses { get; set; }

    //Methods
    public void Attend(string course, DateTime datetime)
    {
    }

    public void WriteExam(string course, DateTime datetime)
    {
    }
}
