using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    // IProductDal - Productla ilgili veritabanında yapacağımız operasyonları (ekle, sil, güncelle gibi ) içeren interfacedir. 
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

 //Code Refactoring