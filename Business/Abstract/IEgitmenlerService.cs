using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEgitmenlerService
    {
        List<Egitmenler> GetAll();
        List<Egitmenler> GetAllByPuanId(int puanId);
        List<Egitmenler> GetAll(object e);
        List<EgitmenlerDetailDto> GetEgitmenDetaylar();
        IResult Add(Egitmenler egitmen);
        Egitmenler GetById(Egitmenler egitmen);

    }
}
