using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarDal:IEntityRepository<Car>
    {
        List<Car> GetAllColorId(int id);
        List<Car> GetAllBrandId(int id);
    }
}
