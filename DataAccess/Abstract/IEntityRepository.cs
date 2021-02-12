using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //class - referans tip olabilir
    // IEntity - IEntity olabilir veya implemente eden bir cnesne olabilir.
    //new (): newlenebilir olmalı
    public interface IEntityRepository<T> where T:class, IEntity, new ()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter); 
        void Add(T entity);
        void UpDate(T entity);
        void Delete(T entity);


    }
}
