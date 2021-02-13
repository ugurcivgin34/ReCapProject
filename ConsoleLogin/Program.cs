using Business.Concrete;
using DataAccess.Create.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            // BrandTest();
             //CarTest();
            //ColorTest(); 


            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //rentalManager.Add(new Rental()
            //{

            //    CarId = 3,
            //    CustomerId = 12,
            //    RentDate = DateTime.Now
            //});

            //rentalManager.Delete(2002);

            //Rental addRental = new Rental()
            //{
            //    CarId = 3,
            //    CustomerId = 13,
            //    RentDate = new DateTime(2016, 7, 9)

            //};

            //rentalManager.Add(addRental);

            rentalManager.Deliver(4);

            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.CarId + " " + rental.CustomerId + " " + rental.RentalId + " " + rental.RentDate + " " + rental.ReturnDate);
            }
            //foreach (var item in rentalManager.GetAvailableCars().Data)
            //{
            //    Console.WriteLine(item.RentalId + "/" + item.CarId + "/" + item.CustomerId + "/" + item.RentDate);
            //}
        }

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    colorManager.Add(new Entities.Concrete.Color { ColorName = "Kırmızı" });
        //    colorManager.Update(new Entities.Concrete.Color { ColorName = "Yeşil" });
        //    colorManager.Delete(2002);
        //    Console.WriteLine(colorManager.GetById(3).ColorName);
        //    foreach (var brand in colorManager.GetAll())
        //    {
        //        Console.WriteLine(brand.ColorId + " " + brand.ColorName);
        //    }
        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            //foreach (var car in carManager.GetCarDetail())
            //{
            //    Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName + " " + car.DailyPrice);
            //}
            //carManager.Add(new Entities.Concrete.Car { BrandId = 2, ColorId = 1, DailyPrice = 2350, Descriptions = "Dizel", ModelYear = 2019 });
            //carManager.Update(new Entities.Concrete.Car { Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 234, Descriptions = "Otomatik", ModelYear = 2015 });
            //carManager.Delete(1001);
            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.Descriptions);
            //}
            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.Descriptions);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Descriptions + " " + car.ModelYear);
            //}
            //if (result.Success)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Descriptions + " " + car.ModelYear);
            //        Console.WriteLine(result.Message);
            //    }
            //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    brandManager.Add(new Entities.Concrete.Brand { BrandName = "Ferrari" });
        //    brandManager.Update(new Entities.Concrete.Brand { BrandId = 3, BrandName = "Tofaş" });
        //    brandManager.Delete(2002);
        //    Console.WriteLine(brandManager.GetById(3).BrandName);
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandId + " " + brand.BrandName);
        //    }
        }
    }
}
