using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class IBrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public IBrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
