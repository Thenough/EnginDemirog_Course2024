using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Abstracts;

public  interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);

    Course Update(Course course);

    void Delete(Course course);
}
