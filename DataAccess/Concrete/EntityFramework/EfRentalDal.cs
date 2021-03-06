﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using DataAccess.Abtsract;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                    join c in context.Cars
                        on r.CarId equals c.CarId
                    join cu in context.Customers
                        on r.CustomerId equals cu.CustomerId
                    join b in context.Brands
                        on c.BrandId equals b.BrandId
                    join u in context.Users
                        on cu.UserId equals u.Id

                    select new RentalDetailDto
                    {
                        RentalId = r.RentalId,
                        CarName = b.BrandName,
                        CompanyName = cu.CompanyName,
                        UserName = u.FirstName + " " + u.LastName,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate
                    };
                return result.ToList();
            }
        }
    }
}