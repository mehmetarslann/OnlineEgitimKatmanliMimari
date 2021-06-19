using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Siparis : IEntity
    {
        public int SiparisId { get; set; }
        public int OgrenciId { get; set; }
        public int EgitmenId { get; set; }
        public DateTime SiparisTarih { get; set; }
    }
}
