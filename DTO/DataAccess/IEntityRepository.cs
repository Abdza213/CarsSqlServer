using DTO.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DTO.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        void Add(T item);

        void Delete(T item);

        void Update(T item);

        T GetById(Expression<Func<T, bool>> filter = null);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);

    }
}
