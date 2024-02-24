using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.DataAccess.Concretes;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business;

public  class InstructorManager
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public List<Instructor> GetAll()
    {
        //busiess rules
        return _instructorDal.GetAll();
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(Instructor instructor)
    { _instructorDal.Delete(instructor); }

    public Instructor Update(Instructor instructor)
    { return _instructorDal.Update(instructor); }
}
