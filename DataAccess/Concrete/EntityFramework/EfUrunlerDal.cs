using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUrunlerDal : EfEntityRepositoryBase<Urunler, OnlineEducationContext>, IUrunlerDal
    {
        public List<UrunlerDetailDto> GetUrunDetaylar()
        {
            using (OnlineEducationContext context = new OnlineEducationContext())
            {
                var result = from u in context.Urunler
                             join kat in context.Kategoriler
                             on u.KategoriId equals kat.KategoriId
                             select new UrunlerDetailDto
                             {
                                 UrunId = u.UrunId,
                                 UrunAd = u.UrunAd,
                                 KategoriId = kat.KategoriId
                             };

                return result.ToList();
            }
        }
    }
}
