using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=12000,ModelYear=2021,Description="Otomatik Vites"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=38000,ModelYear=2021,Description="Benzinli"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=90000,ModelYear=2021,Description="2.El"},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=23000,ModelYear=2021,Description="Hasarlı"},
                new Car{Id=5,BrandId=3,ColorId=3,DailyPrice=34000,ModelYear=2021,Description="Manuel Vites"},
                new Car{Id=6,BrandId=3,ColorId=3,DailyPrice=120000,ModelYear=2021,Description="Hasarsız"},
                new Car{Id=7,BrandId=4,ColorId=4,DailyPrice=125000,ModelYear=2021,Description="Sıfır Araba"},
                new Car{Id=8,BrandId=4,ColorId=4,DailyPrice=8000,ModelYear=2021,Description="Çocuk Arabası"},
                new Car{Id=9,BrandId=5,ColorId=5,DailyPrice=33000,ModelYear=2021,Description="Camları Filmli"},
                new Car{Id=10,BrandId=5,ColorId=5,DailyPrice=41000,ModelYear=2021,Description="Üstü Açık"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deleteCars = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(deleteCars);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c=>c.BrandId==BrandId).ToList();
        }

        public void Update(Car car)
        {
            var updateCars = _cars.SingleOrDefault(c=>c.Id==car.Id);
            updateCars.BrandId = car.BrandId;
            updateCars.ColorId = car.ColorId;
            updateCars.DailyPrice = car.DailyPrice;
            updateCars.ModelYear = car.ModelYear;
            updateCars.Description = car.Description;
        }
    }
}
