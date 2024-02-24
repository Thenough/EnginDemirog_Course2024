using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Abstracts;

public interface ICategoryDal
{
    
        List<Category> GetAll();
        void Add(Category category);

        Category Update(Category category);

        void Delete(Category category);
    }

