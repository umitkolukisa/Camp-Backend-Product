using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint= T yerine yazabileceğimiz objeleri sınırlandırmak.
    //T:class = referans tip yazılabilir
    //IEntity= IEntity interface'i ve bunu implamente eden classlar olabilir.
    //new() = sadece new'lenebilir olanlar olabilir. yani artık IEntity interface olamaz.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
