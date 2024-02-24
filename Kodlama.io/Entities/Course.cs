namespace Kodlama.io.Entities;

public class Course
{
    public int CourseId { get; set; }
    public int CategoryId { get; set; } 
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public List<Instructor> Instructors { get; set; } 
}