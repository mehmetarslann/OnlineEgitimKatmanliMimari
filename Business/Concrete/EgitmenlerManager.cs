using Business.Abstract;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EgitmenlerManager : IEgitmenlerService
    {
        IEgitmenlerDal _egitmenlerDal; // Soyut nesne ile bağlantı kuracağız.

        public EgitmenlerManager(IEgitmenlerDal egitmenlerDal)
        {
            _egitmenlerDal = egitmenlerDal;
        }

        public IResult Add(Egitmenler egitmen)
        {
            if(egitmen.EgitmenAd.Length < 3)
            {
                return new ErrorResult("Eğitmen ismi en az 3 karakter olmalıdır.");
            }
            _egitmenlerDal.Add(egitmen);
            return new Result(true,"Ürün başarıyla eklendi");
        }

        public List<Egitmenler> GetAll()
        {
            // İş kodları yazılacak
            // Yetkisi Varmı? || Siteye Üye mi?

            return _egitmenlerDal.GetAll();
        }

        public List<Egitmenler> GetAll(object e)
        {
            throw new NotImplementedException();
        }

        public List<Egitmenler> GetAllByPuanId(int puanId)
        {
            throw new NotImplementedException();
        }

        public Egitmenler GetById(Egitmenler egitmen)
        {
            throw new NotImplementedException();
        }

        public List<EgitmenlerDetailDto> GetEgitmenDetaylar()
        {
            return _egitmenlerDal.GetEgitmenDetaylar();
        }
    }
}
