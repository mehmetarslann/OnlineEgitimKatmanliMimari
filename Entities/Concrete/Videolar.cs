using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Videolar : IEntity
    {
        public int VideoId { get; set; }
        public string VideoAd { get; set; }
        public string VideoLink { get; set; }
        public int KategoriAd { get; set; }
        public int VideoPuan { get; set; }
    }
}
