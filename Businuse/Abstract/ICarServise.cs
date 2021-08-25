using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Businuse.Abstract
{
    public interface ICarServise
    {
        List<CarDetailDto> GetCarDetails();
    }
}
