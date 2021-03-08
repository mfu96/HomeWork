using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
       List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 3,DailyPrice = 200,ModelYear = 2015,Description = "Az yakar çok kaçar"},
                new Car{Id = 2,BrandId = 1,ColorId = 3,DailyPrice = 200,ModelYear = 2015,Description = "Az yakar çok kaçar"},
                new Car{Id = 3,BrandId = 4,ColorId = 10,DailyPrice = 400,ModelYear = 2020,Description = "Havan yoksa bu sana katar(Ancak acizler için)"},

            };
        }
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=> c.Id== Id).ToList();
        }


        

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(uCar => uCar.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(cDelete => cDelete.Id == car.Id);
            _cars.Remove(carToDelete);


        }

        public List<Car> GetAllByDailyPrice(decimal dailyPriceDecimal)
        {
            return _cars.Where(c => c.DailyPrice == dailyPriceDecimal).ToList();


        }
    }
}
