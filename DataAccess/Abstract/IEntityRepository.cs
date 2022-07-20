using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //T bir Generic constraint'dir. Referans tip ve IEntityi olanları alır.
    //class: referans tip olabilir demektir
    //IEntity: IEntity olabilir veya IEntity implemente eden nesne olabilir.
    //new() : IEntity'nin kendisi olmasını da istemiyoruz bu yüzden newlenebilir olmalıdır.
    //Bu yaptıklarımıza standart oluşturma denir.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
