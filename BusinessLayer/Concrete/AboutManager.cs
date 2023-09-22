using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _abaouDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _abaouDal = aboutDal;
        }
        public void TAdd(About t)
        {
            _abaouDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _abaouDal.Delete(t);
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
          return _abaouDal.GetList();
        }

        public void TUpdate(About t)
        {
           _abaouDal.Update(t);
        }
    }
}
