using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IRezervasyonService : IGenericService<Rezervasyon>
    {
        List<Rezervasyon> GetListWithRezervasyonByWaitAprroval(int id);

        List<Rezervasyon> GetListWithRezervasyonByPrevious(int id);
        List<Rezervasyon> GetListWithRezervasyonByAccepted(int id);
    }
}
