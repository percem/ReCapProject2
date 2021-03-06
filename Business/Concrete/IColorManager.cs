﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IColorManager:IColorService
    {
        IColorDal _colorDal;

        public IColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        List<System.Drawing.Color> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
