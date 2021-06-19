using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOgrencilerService
    {
        List<Ogrenciler> GetAll(object p);
        List<Ogrenciler> GetAllByCategoryId(int id);
        List<OgrencilerDetailDto> GetOgrenciDetaylar();
        List<Ogrenciler> GetAll();

    }
}
