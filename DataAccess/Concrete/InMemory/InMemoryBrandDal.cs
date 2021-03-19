using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryBrandDal : IBrandDal
    // {
    //List<Brand> _brands;

    public class InMemoryBrandDal
    {
        //    _brands = new List<Brand>
        //    {
        //        new Brand{BrandId = 1,BrandName = "Mercedes"},
        //        new Brand{BrandId = 2,BrandName = "BMW"},
        //        new Brand{BrandId = 3,BrandName = "Range Rover"},
        //        new Brand{BrandId = 4,BrandName = "Porsche"}

        //    };
        //}
        //public void Add(Brand brand)
        //{
        //    _brands.Add(brand);
        //}

        //public void Delete(Brand brand)
        //{
        //    Brand brandToDelete = _brands.SingleOrDefault(b=>b.BrandId==brand.BrandId);
        //    _brands.Remove(brandToDelete);
        //}

        //public Brand Get(Expression<Func<Brand, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        //{
        //    return _brands;
        //}

        //public void Update(Brand brand)
        //{
        //    Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
        //    brandToUpdate.BrandName = brand.BrandName;
        //    brandToUpdate.BrandId = brand.BrandId;
        //}
    }
}