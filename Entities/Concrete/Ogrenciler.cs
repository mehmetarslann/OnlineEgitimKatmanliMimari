﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ogrenciler : IEntity
    {
        public int OgrenciId { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public string OgrenciEposta { get; set; }
        public string OgrenciSifre { get; set; }
        public string OgrenciTelefon { get; set; }
        public int OgrenciVideo { get; set; } 

    }
}
