using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class KategorilerDetailDto : IDto
    {
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
    }
}
