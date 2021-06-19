using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUrunlerService
    {
        List<Urunler> GetAll(object p);
        List<Urunler> GetAllByCategoryId(int id);
        List<UrunlerDetailDto> GetUrunDetaylar();
        List<Urunler> GetAll();
        void Add(Urunler urunler);
        Urunler GetById(int urunId);
    }
}
