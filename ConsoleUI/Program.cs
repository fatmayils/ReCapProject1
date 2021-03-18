using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("*************************BrandManager************************************");
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.ModelYear);
            }
            Console.WriteLine("*************************BrandManager************************************");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
            Console.WriteLine("****************************ColorManager***********************************");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine(item.ColorName);
            }

            carManager.Add(new Car {CarId=31,Description="" });
            carManager.Add(new Car {Description = "Yeni model",DailyPrice=290,ColorId=2,BrandId=5 });
            carManager.Add(new Car {  Description = "Çok", DailyPrice = 500, BrandId = 10, ColorId = 9, ModelYear = 2500 });*/
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("************************************************CarManagerDetails**************************************************");
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", item.CarId, item.BrandName, item.ColorName, item.DailyPrice);
            }

        }
    }
}