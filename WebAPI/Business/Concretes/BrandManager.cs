using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
       private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            //business rules

            //maping
            Brand brand = new Brand();
            brand.Name = createBrandRequest.Name;
            brand.CreatedData = DateTime.Now;
            _brandDal.Add(brand);

            //maping
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = brand.Name;
            createdBrandResponse.Id = 4;
            createdBrandResponse.CreatedData = brand.CreatedData;

            return createdBrandResponse;
        }

        public List<GetAllBrandResponse> GetAll()
        {
            List<Brand> brands = _brandDal.GetAll();
            List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();

            foreach (var brand in brands)
            {
                GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
                getAllBrandResponse.Name = brand.Name;
                getAllBrandResponse.Id = brand.Id;
                getAllBrandResponse.CreatedData = brand.CreatedData;

                getAllBrandResponses.Add(getAllBrandResponse);
            }

            return getAllBrandResponses;
        }
    }
}
