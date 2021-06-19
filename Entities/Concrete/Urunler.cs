using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Urunler : IEntity
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int KategoriId { get; set; }
        public string UrunFiyat { get; set; }
    }
}
