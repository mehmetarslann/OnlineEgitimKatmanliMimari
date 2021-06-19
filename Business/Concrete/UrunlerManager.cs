using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class UrunlerManager : IUrunlerService
    {
        IUrunlerDal _urunlerDal;

        public UrunlerManager(IUrunlerDal urunlerDal)
        {
            _urunlerDal = urunlerDal;
        }

        public void Add(Urunler urunler)
        {
            _urunlerDal.Add(urunler);
        }

        public List<Urunler> GetAll()
        {
            // iş kodları yazılacak

            return _urunlerDal.GetAll();
        }

        public List<Urunler> GetAll(object p)
        {
            throw new NotImplementedException();
        }

        public List<Urunler> GetAllByCategoryId(int id)
        {
            return _urunlerDal.GetAll(); // Değiştirilecek
        }

        public Urunler GetById(int urunId)
        {
            return _urunlerDal.Get(u => u.UrunId == urunId);
        }

        public List<UrunlerDetailDto> GetUrunDetaylar()
        {
            return _urunlerDal.GetUrunDetaylar();
        }
    }
}
