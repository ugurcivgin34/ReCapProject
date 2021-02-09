using Business.Concrete;
using DataAccess.Create.EntityFramework;
using System;

namespace ConsoleLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            // BrandTest();
            // CarTest();
            ColorTest(); 
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Entities.Concrete.Color { ColorName = "Kırmızı" });
            colorManager.Update(new Entities.Concrete.Color { ColorName = "Yeşil" });
            colorManager.Delete(2002);
            Console.WriteLine(colorManager.GetById(3).ColorName);
            foreach (var brand in colorManager.GetAll())
            {
                Console.WriteLine(brand.ColorId + " " + brand.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName + " " + car.DailyPrice);
            }
            carManager.Add(new Entities.Concrete.Car { BrandId = 2, ColorId = 1, DailyPrice = 2350, Descriptions = "Dizel", ModelYear = 2019 });
            carManager.Update(new Entities.Concrete.Car { Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 234, Descriptions = "Otomatik", ModelYear = 2015 });
            carManager.Delete(1001);
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Descriptions);
            }
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Descriptions);
            }
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Descriptions + " " + car.ModelYear);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Entities.Concrete.Brand { BrandName = "Ferrari" });
            brandManager.Update(new Entities.Concrete.Brand { BrandId = 3, BrandName = "Tofaş" });
            brandManager.Delete(2002);
            Console.WriteLine(brandManager.GetById(3).BrandName);
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }
    }
}
