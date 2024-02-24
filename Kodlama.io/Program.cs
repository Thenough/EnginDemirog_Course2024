// See https://aka.ms/new-console-template for more information
using Kodlama.io.Business;
using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.DataAccess.Concretes;
using Kodlama.io.Entities;


Console.WriteLine("Kurslar Listesi");

CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> listCourses = courseManager.GetAll();
for (int i = 0; i < listCourses.Count; i++)
{
    Console.WriteLine(listCourses[i].Name);
}


Course course = new Course();
course.Name = "Temel Seviye C#";
courseManager.Add(course);

List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name);
}


courseManager.Delete(course);
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name);
}


CategoryManager categoryManager = new CategoryManager(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine(categories[i].CategoryName);
}


Category category = new Category();
category.CategoryName = "Programlama";
category.CategoryId = 1;
category.Courses = new List<Course>();

categoryManager.Update(category);


List<Category> categories2 = categoryManager.GetAll();

for (int i = 0; i < categories2.Count; i++)
{
    Console.WriteLine(categories2[i].CategoryName);
}


InstructorManager instructor = new InstructorManager( new InstructorDal());
List<Instructor> instructors = instructor.GetAll();
for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i].FirstName + instructors[i].LastName);
}

Instructor instructor1 = instructors.Where(i => i.InstructorId == 2).FirstOrDefault();
instructor1.City = "Kocaeli";
instructor.Update(instructor1);

Instructor updateInstructor = instructors.Where(i => i.InstructorId == 2).FirstOrDefault();
Console.WriteLine(instructor1.FirstName + " " + instructor1.City);
