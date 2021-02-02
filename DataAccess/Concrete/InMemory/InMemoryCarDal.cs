using DataAccess.Abstract;
using Entities.Concrete;
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
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2019", DaliyPrice = 1300, Description = "600 Beygir"},
                new Car{Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2015", DaliyPrice = 970, Description = "320 Beygir"},
                new Car{Id = 5, BrandId = 4, ColorId = 5, ModelYear = "2012", DaliyPrice = 690, Description = "190 Beygir"},
                new Car{Id = 4, BrandId = 3, ColorId = 4, ModelYear = "2020", DaliyPrice = 2000, Description = "800 Beygir"},
                new Car{Id = 3, BrandId = 2, ColorId = 1, ModelYear = "2007", DaliyPrice = 450, Description = "280 Beygir"},
            };
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DaliyPrice = car.DaliyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
