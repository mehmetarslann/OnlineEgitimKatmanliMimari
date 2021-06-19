using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Puanlar : IEntity
    {
        public int PuanId { get; set; }
        public string Puan { get; set; }
    }
}
