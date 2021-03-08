using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //Adam mı ki erişecek? if else vs
            return _carDal.GetAll();

        }

        public void AddCar(Car car)
        {
            _carDal.Add(car);
        }

        public void UpdateCar(Car car)
        {
            _carDal.Update(car);
        }

        public void DeleteCar(Car car)
        {
            _carDal.Delete(car);
        }
    }
}
