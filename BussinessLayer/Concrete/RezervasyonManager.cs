﻿using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class RezervasyonManager : IRezervasyonService
    {
        IRezervasyonDal _rezervasyonDal;

        public RezervasyonManager(IRezervasyonDal rezervasyonDal)
        {
            _rezervasyonDal = rezervasyonDal;
        }

        public List<Rezervasyon> GetListWithRezervasyonByAccepted(int id)
        {
            return _rezervasyonDal.GetListWithRezervasyonByAccepted(id);
        }

        public List<Rezervasyon> GetListWithRezervasyonByPrevious(int id)
        {
            return _rezervasyonDal.GetListWithRezervasyonByPrevious(id);
        }

        public List<Rezervasyon> GetListWithRezervasyonByWaitAprroval(int id)
        {
            return _rezervasyonDal.GetListWithRezervasyonByWaitApproval(id);
        }

        public void TAdd(Rezervasyon t)
        {
            _rezervasyonDal.Insert(t);
        }

        public void TDelete(Rezervasyon t)
        {
            throw new NotImplementedException();
        }

        public Rezervasyon TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervasyon> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Rezervasyon t)
        {
            throw new NotImplementedException();
        }
    }
}
