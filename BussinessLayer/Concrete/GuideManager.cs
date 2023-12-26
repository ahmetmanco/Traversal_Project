using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuidDal _guideDal;

        public GuideManager(IGuidDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Guide t)
        {
            throw new NotImplementedException();
        }

        public Guide TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TUpdate(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}
