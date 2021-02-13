using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="BMW"},
                new Brand{BrandId=2,BrandName="MERCEDES"},
                new Brand{BrandId=3,BrandName="ROLLY ROYCE"},
                new Brand{BrandId=4,BrandName="FORD"},
                new Brand{BrandId=5,BrandName="SCODA"},
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            var deleteBrands = _brands.SingleOrDefault(b=>b.BrandId==brand.BrandId);
            _brands.Remove(deleteBrands);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetById(int brand)
        {
            return _brands.Where(b=>b.BrandId==brand).ToList();
        }

        public void Update(Brand brand)
        {
            var updateBrands = _brands.SingleOrDefault(b=>b.BrandId==brand.BrandId);
            updateBrands.BrandName = brand.BrandName;
        }
    }
}
