using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());

            foreach (var cars in carManager.GetCars())
            {
                foreach (var brands in brandManager.GetBrands())
                {
                    if (cars.BrandId == brands.BrandId)
                    {
                        Console.WriteLine("{0} model {1} {2} günlük ücreti {3}",cars.ModelYear,brands.BrandName,cars.Description,cars.DaliyPrice);
                    }
                }
            }


            
            
            
           

            //foreach (var brand in brandManager.GetBrands())
            //{
            //    Console.WriteLine("{0} = {1}",brand.BrandId,brand.BrandName);
            //}

          
            //foreach (var car in carManager.GetCars())
            //{
            //    Console.WriteLine(car.ModelYear);
            //}

        }
    }
}
