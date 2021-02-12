using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    // IProductDal - Productla ilgili veritabanında yapacağımız operasyonları (ekle, sil, güncelle gibi ) içeren interfacedir. 
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void UpDate(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); // // ürünleri kategoriye göre filtrele.
    }
}
