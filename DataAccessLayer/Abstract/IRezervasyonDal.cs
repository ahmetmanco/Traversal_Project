using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRezervasyonDal : IGenericDal<Rezervasyon>
    {
        List<Rezervasyon> GetListWithRezervasyonByWaitApproval(int id);
        List<Rezervasyon> GetListWithRezervasyonByAccepted(int id);
        List<Rezervasyon> GetListWithRezervasyonByPrevious(int id);
    }
}
