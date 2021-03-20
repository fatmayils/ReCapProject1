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

             //BrandManager brandManager = BrandAdd();
            //BrandManager brandManager = BrandDelete();
           //BrandGetAll();
          //BrandUpdate();
         //ColorManager colorManager = ColorAdd();
        //ColorManager colorManager = ColorDelete();
       //ColorGetAll();
      //ColorUpdate();
     //CarAdd();
    //CarDelete();
   //CarUpdate();
  //CarGetAll();
 //CarDetails();

        }

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result5 = carManager.GetCarDetails();
            if (result5.Success)
            {
                foreach (var dto in result5.Data)
                {
                    Console.WriteLine(dto.BrandName + "\t" + dto.ColorName + "\t" + dto.DailyPrice);
                }
            }
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result4 = carManager.GetAll();
            if (result4.Success)
            {
                Console.WriteLine(result4.Message);
                foreach (var car in result4.Data)
                {
                    Console.WriteLine(car.CarId + "\t" + car.BrandId + "\t" + car.ColorId + "\t" + car.Description);
                }
            }
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result3 = carManager.Update(new Car { CarId = 9, BrandId = 12, DailyPrice = 599 });
            if (result3.Success)
            {
                Console.WriteLine(result3.Message);
            }
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result2 = carManager.Delete(new Car { CarId = 4 });
            if (result2.Success)
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car { BrandId = 3, ColorId = 8, Description = "araba araba", });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result4 = brandManager.Update(new Brand { BrandId = 7, BrandName = "Güzel Araba" });
            if (result4.Success)
            {
                Console.WriteLine(result4.Message);
            }
        }

        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result3 = brandManager.GetAll();
            if (result3.Success == true)
            {
                foreach (var brand in result3.Data)
                {
                    Console.WriteLine(brand.BrandId + "\t" + brand.BrandName);
                }
            }
        }

        private static BrandManager BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result2 = brandManager.Delete(new Brand { BrandId = 17 });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }

            return brandManager;
        }

        private static BrandManager BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result1 = brandManager.Add(new Brand { BrandName = "araba" });
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Message);
            }

            return brandManager;
        }


       
             private static void ColorUpdate()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result4 = colorManager.Update(new Color { ColorId = 7, ColorName = "Güzel Renk" });
            if (result4.Success)
            {
                Console.WriteLine(result4.Message);
            }
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result3 = colorManager.GetAll();
            if (result3.Success == true)
            {
                foreach (var color in result3.Data)
                {
                    Console.WriteLine(color.ColorId + "\t" + color.ColorName);
                }
            }
        }

        private static ColorManager ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result2 = colorManager.Delete(new Color { ColorId = 13 });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }

            return colorManager;
        }

        private static ColorManager ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result1 = colorManager.Add(new Color { ColorName = "araba" });
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Message);
            }

            return colorManager;
        }
    }
}