using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
    }

        public void Add(Car car)
        {
            if (car.Description.Length > 2&&car.DailyPrice>0) 
            {
                _carDal.Add(car);
                Console.WriteLine("Ekleme Başarılı");
            }
            else
            {
                Console.WriteLine("Araba için en az 2 karakterden oluşan bir desciription tanımlamalı,\nve günlük fiyatın 0 dan küçük olmamasına dikkat ediniz.\nEkleme başarısız");

            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Silme Başarılı");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllBrandId(int id)
        {
            return _carDal.GetAllBrandId(id);
        }

        public List<Car> GetAllColorId(int id)
        {
            return _carDal.GetAllColorId(id);
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public void Update(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Güncelleme Başarılı");
            }

            else {
                Console.WriteLine("Araba için en az 2 karakterden oluşan bir desciription tanımlamalı,\nve günlük fiyatın 0 dan küçük olmamasına dikkat ediniz.\nGüncelleme başarısız");
                        } }
    }
}
