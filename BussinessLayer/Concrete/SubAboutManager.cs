using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EF;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        EFSubAboutDal _subAboutDal;

        public SubAboutManager(EFSubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TAdd(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
