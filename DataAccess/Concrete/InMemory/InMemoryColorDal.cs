using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color{ColorId=1,ColorName="White"},
                new Color{ColorId=2,ColorName="Black" },
                new Color{ColorId=3,ColorName="Yellow"},
                new Color{ColorId=4,ColorName="Purple"},
                new Color{ColorId=5,ColorName="Blue"}
            };
        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            var deleteColors = _colors.SingleOrDefault(t=>t.ColorId==color.ColorId);
            _colors.Remove(deleteColors);
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetById(int ColorId)
        {
            return _colors.Where(t=>t.ColorId==ColorId).ToList();
        }

        public void Update(Color color)
        {
            var updateColors = _colors.SingleOrDefault(t=>t.ColorId==color.ColorId);
            updateColors.ColorName = color.ColorName;
        }
    }
}
