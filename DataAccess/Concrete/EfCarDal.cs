using DataAccess.Abstract;
using DTO.DataAccess;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using SqlServer.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCarDal : EntityRepositoryBase<Cars, NorthWindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
           using(NorthWindContext context = new NorthWindContext())
            {
                var result = from P in context.cars
                             join C in context.brands
                             on P.BrandId equals C.BrandId 
                             
                             select new CarDetailDto 
                             {
                                 BrandId = C.BrandId,
                                 CarId = P.CarId,
                                 BrandName = C.BrandName,
                                 DailyPrice = P.DailyPrice,
                                 Description = P.Description 
                             };
                return result.ToList();

            }
        }
    }
}
