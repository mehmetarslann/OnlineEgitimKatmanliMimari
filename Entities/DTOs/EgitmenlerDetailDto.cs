using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class EgitmenlerDetailDto : IDto
    {
        public int EgitmenId { get; set; }
        public string EgitmenAd { get; set; }
        public string EgitmenEposta { get; set; }
        public string EgitmenSifre { get; set; }
        public string EgitmenTelefon { get; set; }
        public int EgitmenPuan { get; set; }
        public int EgitmenVideo { get; set; }
    }
}
