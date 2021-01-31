using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car> {
            new Car{ CarId=1,BrandId=1,ColorId=1,DailyPrice=15000,Description="Linea",ModelYear=2020}, 
            new Car { CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 170000, Description = "Juke", ModelYear = 2021 }
            };
    }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            
           Car CarToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public Car GetById(int carId)
        {
            Car findedCar = _cars.SingleOrDefault(c => c.CarId ==carId);
            return findedCar;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
    }
}
