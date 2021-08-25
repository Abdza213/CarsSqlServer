using Businuse.Abstract;
using DataAccess.Concrete;
using Entites.Concrete;
using SqlServer.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Businuse.Concrete
{
    public class CarManeger : ICarServise
    {
        EfCarDal _cars;

        public CarManeger(EfCarDal cars)
        {
            _cars = cars;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _cars.GetCarDetails();
        }
    }
}
