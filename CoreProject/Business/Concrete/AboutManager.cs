using Access.Abstract;
using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager : IGenericService<About>
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal=aboutDal;
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(id);
        }

        public void TAdd(About entity)
        {
            _aboutDal.Add(entity);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetAll();
        }

        public void TRemove(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
