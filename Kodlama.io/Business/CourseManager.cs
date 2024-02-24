using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business;

public  class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        //busiess rules
        return _courseDal.GetAll();
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void  Delete(Course course)
    {  _courseDal.Delete(course);}

    public Course Update (Course course)
    { return _courseDal.Update(course);}
}
