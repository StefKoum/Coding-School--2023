using System;

public class Schedule
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public Guid ProfessorId { get; set; }
    public DateTime Calendar { get; set; }
}
