using DataAccess.Abstract;
using DTO.DataAccess;
using Entites.Concrete;
using SqlServer.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfColorDal : EntityRepositoryBase<Colors, NorthWindContext>, IColorDal
    {
    }
}
