using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            

            foreach (var brand in brandManager.GetBrands())
            {
                Console.WriteLine("{0} = {1}",brand.BrandId,brand.BrandName);
            }

            
            

            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.ModelYear);
            }

        }
    }
}
