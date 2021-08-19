using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    BrandId=2,
                    ColorId=1,
                    DailyPrice=10000,
                    ModelYear=DateTime.Now,
                    Description = "Black Car"
                },
                new Car
                {
                    Id = 2,
                    BrandId=1,
                    ColorId=1,
                    DailyPrice=20000,
                    ModelYear=DateTime.Now,
                    Description = "Red Car"
                },
                new Car
                {
                    Id = 3,
                    BrandId=2,
                    ColorId=2,
                    DailyPrice=15000,
                    ModelYear=DateTime.Now,
                    Description = "White Car"
                }
            };  
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.Where(c => c.Id == car.Id).SingleOrDefault();
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car car = _cars.Where(c => c.Id == id).SingleOrDefault();
            return car;
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.Where(c => c.Id == car.Id).SingleOrDefault();
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
