using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sepet : IEntity
    {
        public int SepetId { get; set; }
        public int UrunAd { get; set; }
        public string Fiyat { get; set; }
    }
}
