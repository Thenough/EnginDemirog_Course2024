using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> categories;

    public CategoryDal()
    {
        Category category1 = new Category();
        category1.CategoryId = 1;
        category1.CategoryName = "Programlama";
        category1.Courses = new List<Course> { new Course {  CategoryId =1 , CourseId =2,
            Name = "C#",
            Description ="İleri Seviye C# Programlama Dersleri"}};



        Category category2 = new Category();
        category2.CategoryId = 2;
        category2.CategoryName = "Java";
        category2.Courses = new List<Course> { new Course {  CategoryId =2 , CourseId =3,
            Name = "Java",
            Description ="İleri Seviye Java Programlama Dersleri"}};

        categories = new List<Category>() { category1, category2 };

    }

    //CRUD İşlemleri

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(Category category)
    {
        categories.Remove(category);
    }

    public Category Update(Category category)
    {
        var categoryItem = categories.Where(c => c.CategoryId == category.CategoryId).FirstOrDefault();
        categoryItem.CategoryId = category.CategoryId;
        categoryItem.CategoryName = category.CategoryName;
        categoryItem.Courses = category.Courses;

        return categoryItem; 
    }

    public List<Category> GetAll()
    {
        return categories;
    }
}

