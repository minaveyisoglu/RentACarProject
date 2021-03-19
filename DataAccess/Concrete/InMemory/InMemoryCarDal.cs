using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal : ICarDal
    //{
    //List<Car> _cars;

    public class InMemoryCarDal
    {
        //    _cars = new List<Car>
        //    {
        //        new Car{CarId =1, BrandId=1, ColorId=1, DailyPrice=150, ModelYear="2010", Descriptions="Manuel" },
        //        new Car{CarId=2, BrandId=2, ColorId=2, DailyPrice=185, ModelYear="2015", Descriptions="Manuel" },
        //        new Car{CarId =3, BrandId=3, ColorId=3, DailyPrice=200, ModelYear="2018", Descriptions="Otomatik" },
        //        new Car{CarId =4, BrandId=4, ColorId=4, DailyPrice=350, ModelYear="2029", Descriptions="Otomatik" }
        //    };
        //}

        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    _cars.Remove(carToDelete);
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}



        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    return _cars;
        //}

        //public List<Car> GetById(int Id)
        //{
        //    return _cars.Where(c => c.CarId == Id).ToList();
        //}

        //public List<CarDetailDto> GetCarDetails()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    carToUpdate.CarId = car.CarId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Descriptions = car.Descriptions;
        //    carToUpdate.ModelYear = car.ModelYear;
        //}
    }
}
