using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{

    //çıplak class kalmasın. eğer bir class herhangi bir inheritance veya interface implantasyon almıyorsa anla ki ilerde sorun yaşarsın bro.
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
