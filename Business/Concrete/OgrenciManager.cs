using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OgrenciManager : IOgrencilerService
    {
        IOgrencilerDal _ogrencilerDal;

        public OgrenciManager(IOgrencilerDal ogrencilerDal)
        {
            _ogrencilerDal = ogrencilerDal;
        }

        public List<Ogrenciler> Getall()
        {
            // İş kodları

            return _ogrencilerDal.GetAll();
        }

        public List<Ogrenciler> GetAll(object p)
        {
            throw new NotImplementedException();
        }

        public List<Ogrenciler> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Ogrenciler> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public Ogrenciler GetById(int OgrenciId)
        {
            return _ogrencilerDal.Get(o => o.OgrenciId == OgrenciId);
        }

        public List<OgrencilerDetailDto> GetOgrenciDetaylar()
        {
            return _ogrencilerDal.GetOgrenciDetaylar();
        }
    }
}
