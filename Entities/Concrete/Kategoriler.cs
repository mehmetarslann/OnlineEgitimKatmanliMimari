using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kategoriler : IEntity
    {
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
    }
}
