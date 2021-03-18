using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var addedEntity = context.Entry(car);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            };

        }

        public void Delete(Car car)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var deletedEntity = context.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            };
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (NortwindContext context=new NortwindContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            };
        }

        public List<Car> GetAllBrandId(int id)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return  context.Set<Car>().Where(p=>p.BrandId==id).ToList();
            };
        }

        public List<Car> GetAllColorId(int id)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Set<Car>().Where(p => p.ColorId == id).ToList();
            };
        }

        public void Update(Car car)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var updatedEntity = context.Entry(car);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            };
        }

        List<Car> IEntityRepository<Car>.GetById(int id)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Set<Car>().Where(p => p.CarId == id).ToList();
            };
        }
    }
}
