using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes
{
    
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.Name = "C#";
            course1.Description = "İleri Seviye C#";
            course1.Price = 100;
            course1.Instructors = new List<Instructor> { new Instructor { InstructorId = 1, FirstName = "Engin", LastName = "Demiroğ" } };

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.Name = "Python";
            course2.Description = "İleri Seviye Python";
            course2.Price = 100;
            course2.Instructors = new List<Instructor> { new Instructor { InstructorId = 2, FirstName = "Murat", LastName = "Yücedağ" } };
           
            courses = new List<Course> { course1, course2};
        }


        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
        }

        public Course Update(Course course)
        {
            var courseItem = courses.Where(c => c.CourseId == course.CourseId).FirstOrDefault();
            courseItem.Name  = course.Name;
            courseItem.Description = course.Description;
            courseItem.Price = course.Price;
            courseItem.Instructors = course.Instructors;

            return courseItem;
        }

        public List<Course> GetAll()
        {
            return courses;
        }
    }
}
