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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcements;

        public AnnouncementManager(IAnnouncementDal announcements)
        {
            _announcements = announcements;
        }

        public void TAdd(Announcement t)
        {
            _announcements.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcements.Delete(t);
        }

        public Announcement TGetById(int id)
        {
            return _announcements.GetById(id);
             
        }

        public List<Announcement> TGetList()
        {
            return _announcements.GetList();
        }

        public void TUpdate(Announcement t)
        {
            _announcements.Update(t);
        }
    }
}
