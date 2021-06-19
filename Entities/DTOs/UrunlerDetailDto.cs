using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UrunlerDetailDto : IDto
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int KategoriId { get; set; }


    }
}
