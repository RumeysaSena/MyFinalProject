using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    // IProductDal - Productla ilgili veritabanında yapacağımız operasyonları (ekle, sil, güncelle gibi ) içeren interfacedir. 
    public interface IProductDal : IEntityRepository<Product>
    {
       // // ürünleri kategoriye göre filtrele.
    }
}
