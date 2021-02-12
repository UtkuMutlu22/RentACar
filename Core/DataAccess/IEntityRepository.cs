using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{

    //class: referans tip olabilir!
    //IEntity: IEntity yada IEntity i implemente eden nesne olabilir!
    //new(): newlenebilir olmalı!

    public interface IEntityRepository<T> where T : class, IEntity, new()  //Generic constrain
    {
        T Get(Expression<Func<T, bool>> filter);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}

