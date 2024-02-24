using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors = new List<Instructor>();
    public InstructorDal()
    {
        

        Instructor instructor1 = new Instructor();
        instructor1.InstructorId = 1;
        instructor1.FirstName = "Engin";
        instructor1.LastName = "Demiroğ";
        instructor1.City = "Ankara";

        Instructor instructor2 = new Instructor();
        instructor2.InstructorId = 2;
        instructor2.FirstName = "Murat";
        instructor2.LastName = " Yücedağ";
        instructor2.City = "Ankara";

        instructors = new List<Instructor> { instructor1, instructor2 };
    }

    public void Add(Instructor instructor)
    {
       instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        
       instructors.Remove(instructor);
    }

    public List<Instructor> GetAll()
    {
       return instructors;
    }

    public Instructor Update(Instructor instructor)
    {
       var categoryItem = instructors.Where( i => i.InstructorId == instructor.InstructorId ).FirstOrDefault();
       
        categoryItem.InstructorId = instructor.InstructorId;
        categoryItem.FirstName = instructor.FirstName; 
        categoryItem.LastName = instructor.LastName;
        categoryItem.City = instructor.City;

        return categoryItem;
    }
}
