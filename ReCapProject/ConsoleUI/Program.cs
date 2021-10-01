using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddBrand();
            //DeleteBrand();
            //UpdateBrand();
            //GetAllBrands();
            //GetBrand();

            //AddColor();
            //DeleteColor();
            //UpdateColor();
            //GetAllColors();
            //GetColor();

            //AddCar();
            //DeleteCar();
            //UpdateCar();
            //GetAllCars();
            //GetCar();

            //GetCatDetails();

            //AddUser();

            //AddCustomer();
            //AddRental();

        }

        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EFRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Now
            });
            Console.WriteLine(result.Message);
        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
            var result = customerManager.Add(new Customer { UserId = 2, CompanyName = "Alicompany" });
            Console.WriteLine(result.Message);
        }

        private static void AddUser()
        {
            UserManager userManager = new UserManager(new EFUserDal());
            userManager.Add(new User
            {
                FirstName = "Fikrat",
                LastName = "Mammadov",
                Email = "fikrat@gmail.com",
            });
            userManager.Add(new User
            {
                FirstName = "Ali",
                LastName = "Mammadov",
                Email = "ali@gmail.com",
            });
            userManager.Add(new User
            {
                FirstName = "Togrul",
                LastName = "Mesimli",
                Email = "togrul@gmail.com",
            });
        }

        private static void GetCatDetails()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"{car.CarName} - {car.BrandName} - {car.ColorName} - {car.DailyPrice}");
            }
        }

        private static void GetCar()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Car car = carManager.GetById(3).Data;
            Console.WriteLine(car.Name);
        }

        private static void GetAllCars()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine($"{car.Id} - {car.Name} - {car.Description}");
            }
        }

        private static void UpdateCar()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            using (ReCapContext context = new ReCapContext())
            {
                Car updatedCar = context.Cars.SingleOrDefault(c => c.Id == 1);
                updatedCar.ModelYear = Convert.ToDateTime("2006 - 01-01");
                carManager.Update(updatedCar);
            }
        }

        private static void DeleteCar()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            using (ReCapContext context = new ReCapContext())
            {
                Car deletedCar = context.Cars.SingleOrDefault(c => c.Id == 2);
                carManager.Delete(deletedCar);
            }
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            //carManager.Add(new Car { Name = "BMW X5", BrandId = 1, ColorId = 1, Description = "BMW X5 desc", DailyPrice = 20000 });
            //carManager.Add(new Car { Name = "BMW X6", BrandId = 1, ColorId = 2, Description = "BMW X6 desc", DailyPrice = 30000 });
            //carManager.Add(new Car { Name = "Opel Astra", BrandId = 2, ColorId = 2, Description = "Opel Astra desc", DailyPrice = 10000 });
            var result = carManager.Add(new Car { Name = "O", BrandId = 2, ColorId = 2, Description = "Opel Astra desc", DailyPrice = 10000 });
            Console.WriteLine(result.Message);
        }

        private static void GetColor()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());
            Color color = colorManager.GetById(2).Data;
            Console.WriteLine(color.Name);
        }

        private static void GetAllColors()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine($"{color.Id} - {color.Name}");
            }
        }

        private static void UpdateColor()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());
            using (ReCapContext context = new ReCapContext())
            {
                Color updatedColor = context.Colors.SingleOrDefault(c => c.Id == 2);
                updatedColor.Name = "White";
                colorManager.Update(updatedColor);
            }
        }

        private static void DeleteColor()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());
            using (ReCapContext context = new ReCapContext())
            {
                Color deletedColor = context.Colors.SingleOrDefault(c => c.Id == 3);
                colorManager.Delete(deletedColor);
            }
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());
            colorManager.Add(new Color { Name = "Black" });
            colorManager.Add(new Color { Name = "Red" });
            colorManager.Add(new Color { Name = "White" });
        }

        private static void GetBrand()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            Console.WriteLine(brandManager.GetById(1).Data.Name);
        }

        private static void GetAllBrands()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Id + " - " + brand.Name);
            }
        }

        private static void UpdateBrand()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            using (ReCapContext context = new ReCapContext())
            {
                Brand updatedBrand = context.Brands.SingleOrDefault(b => b.Id == 2);
                updatedBrand.Name = "Opel";
                brandManager.Update(updatedBrand);
            }
        }

        private static void DeleteBrand()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            using (ReCapContext context = new ReCapContext())
            {
                Brand deletedBrand = context.Brands.SingleOrDefault(b => b.Id == 3);
                brandManager.Delete(deletedBrand);
            }
        }

        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            //var result = brandManager.Add(new Brand { Name = "Mercedes" });
            //Console.WriteLine(result.Message);

        }
    }
}
