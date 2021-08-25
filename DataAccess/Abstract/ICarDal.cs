using DTO.DataAccess;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Cars>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
