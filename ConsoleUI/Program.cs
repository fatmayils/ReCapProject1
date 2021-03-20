using Business.Abstract;
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
            //BrandAdd();
            //BrandDelete();
            //BrandGetAll();
            //BrandUpdate();
            //ColorAdd();
            //ColorDelete();
            //ColorGetAll();
            //ColorUpdate();
            //CarAdd();
            //CarDelete();
            //CarUpdate();
            //CarGetAll();
            //CarDetails();
            //UserAdd
            //UserUpdate();
            //UserDelete();
            //UserGetAll();
            //UserById
            //RentalAdd();
            //RentalDelete();
            //RentalUpdate();
            //RentalById();
            // RentalGetAll();//çalışmadı
            //CustomerAdd();
            // CustomerUpdate();
            //CustomerDelete();
            //CustomerGetAll();
            //CustomerById();

            IRentalService rentalManager = new RentalManager(new EfRentalDal());
            var result2 = rentalManager.Add(new Rental
            {
                CarId =5,
                CustomerId =7,
               RentDate = new DateTime(2001,12,13),
              //ReturnDate = new DateTime(2001,02,01)
            });
                Console.WriteLine(result2.Message);
          
        }

        private static void CustomerById()
        {
            ICustomerService customerManager = new CustomerManager(new EfCustomerDal());
            var result1 = customerManager.GetById(7);
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Data.CompanyName);
            }
        }

        private static void CustomerGetAll()
        {
            ICustomerService customerManager = new CustomerManager(new EfCustomerDal());
            var result1 = customerManager.GetAll();
            if (result1.Success == true)
            {
                foreach (var item in result1.Data)
                {
                    Console.WriteLine(item.CompanyName);
                }
            }
        }

        private static void CustomerDelete()
        {
            ICustomerService customerManager = new CustomerManager(new EfCustomerDal());
            var result1 = customerManager.Delete(new Customer
            {
                CustomerId = 2,
                UserId = 2,
                CompanyName = "solvia"
            });
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Message);
            }
        }

        private static void CustomerUpdate()
        {
            ICustomerService customerManager = new CustomerManager(new EfCustomerDal());
            var result1 = customerManager.Update(new Customer
            {
                CustomerId = 2,
                UserId = 2,
                CompanyName = "solvia"
            });
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Message);
            }
        }

        private static void UserById()
        {
            IUserService userManager = new UserManager(new EfUserDal());
            var result = userManager.GetById(6);
            if (result.Success == true)
            {
                Console.WriteLine(result.Data.FirstName + "\t" + result.Data.LastName);

            }
        }

        private static void UserGetAll()
        {
            IUserService userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.FirstName + "\t" + item.LastName);
                }
            }
        }

        private static void UserDelete()
        {
            IUserService userManager = new UserManager(new EfUserDal());
            var result = userManager.Delete(new User
            {
                UserId = 5,
                FirstName = "derya",
                LastName = "mola",
                Email = "moladerya@gmail.com",
                Password = "12345"
            });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserUpdate()
        {
            IUserService userManager = new UserManager(new EfUserDal());
            var result = userManager.Update(new User
            {
                UserId = 5,
                FirstName = "derya",
                LastName = "mola",
                Email = "moladerya@gmail.com",
                Password = "12345"
            }); ;
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalGetAll()
        {
            IRentalService rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ReturnDate + "\t" + item.ReturnDate);
                }
            }
        }

        private static void RentalById()
        {
            IRentalService rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetById(19);
            if (result.Success == true)
            {
                Console.WriteLine(result.Data.RentalId + "\t" + result.Data.RentDate);
            }
        }

        private static void RentalUpdate()
        {
            IRentalService rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Update(new Rental
            {
                RentalId = 1,
                CarId = 3,
                CustomerId = 2,
                RentDate = new DateTime(2001 / 12 / 13),
                ReturnDate = new DateTime(2001 / 2 / 1)
            });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalDelete()
        {
            IRentalService rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Delete(new Rental
            {
                RentalId = 2,
                CarId = 3,
                CustomerId = 2,
                RentDate = new DateTime(2001 / 12 / 13),
                ReturnDate = new DateTime(2001 / 2 / 1)
            });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalAdd()
        {
            IRentalService rentalManager = new RentalManager(new EfRentalDal());
            var result2 = rentalManager.Add(new Rental
            {
                CarId = 3,
                CustomerId = 2,
                RentDate = new DateTime(2001 / 12 / 13),
                ReturnDate = new DateTime(2001 / 2 / 1)
            });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void UserAdd()
        {
            IUserService userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User
            {
                FirstName = "derya",
                LastName = "mola",
                Email = "moladerya@gmail.com",
                Password = "12345"
            });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerAdd()
        {
            ICustomerService customerManager = new CustomerManager(new EfCustomerDal());
            var result1 = customerManager.Add(new Customer
            {
                UserId = 2,
                CompanyName = "solvia"
            });
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Message);
            }
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
            if (result3.Success==true)
            {
                Console.WriteLine(result3.Message);
            }
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result2 = carManager.Delete(new Car { CarId = 4 });
            if (result2.Success==true)
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car { BrandId = 3, ColorId = 8, Description = "araba araba",DailyPrice=678,ModelYear=2009 });
            if (result.Success==true)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result4 = brandManager.Update(new Brand { BrandId = 7, BrandName = "Güzel Araba" });
            if (result4.Success==true)
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

        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result2 = brandManager.Delete(new Brand { BrandId = 17 });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result1 = brandManager.Add(new Brand { BrandName = "araba" });
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Message);
            }

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

        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result2 = colorManager.Delete(new Color { ColorId = 13 });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }

        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result1 = colorManager.Add(new Color { ColorName = "araba" });
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Message);
            }
        }
    }
}