using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.AddCar(new Car { BrandId = 4, ColorId = 6, DailyPrice = 350, Description = "Afilli mi afilli", Id = 4, ModelYear = 2021 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }




        }
    }
}
