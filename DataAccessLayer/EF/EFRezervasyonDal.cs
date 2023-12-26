using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF
{
    public class EFRezervasyonDal : GenericRepository<Rezervasyon>, IRezervasyonDal
    {
        public List<Rezervasyon> GetListWithRezervasyonByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Rezervasyonss.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();
            }
        }

        public List<Rezervasyon> GetListWithRezervasyonByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Rezervasyonss.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
            }
        }

        public List<Rezervasyon> GetListWithRezervasyonByWaitApproval(int id)
        {
            using(var context = new Context())
            {
                return context.Rezervasyonss.Include(x=>x.Destination).Where(x=>x.Status=="Onay Bekliyor" && x.AppUserId == id).ToList();
            }
        }
    }
}
