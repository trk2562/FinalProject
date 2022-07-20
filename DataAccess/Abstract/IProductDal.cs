using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

//Önce interface'leri kur.

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
