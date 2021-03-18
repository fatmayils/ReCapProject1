using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetById(int id);
        List<Brand> GetAll();
        void Add(Brand entity);
        void Update(Brand entity);
        void Delete(Brand entity);
    }
}
