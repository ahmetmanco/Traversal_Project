using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF
{
    public class EFGuideDal : GenericRepository<Guide>, IGuidDal
    {
        Context context = new Context();
        public void ChangeToFalseByGuide(int id)
        {
            
            var value = context.Guidess.Find(id);
            value.Status = false;
            context.Update(value);
            context.SaveChanges();
            
        }

        public void ChangeToTrueByGuide(int id)
        {
            var value = context.Guidess.Find(id);
            value.Status= true;
            context.Update(value);
            context.SaveChanges();
        }
    }
}
