using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abtsract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}