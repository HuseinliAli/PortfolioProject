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
    public class IHeaderManager : IGenericService<Header>
    {
        IHeaderDal _headerDal;

        public IHeaderManager(IHeaderDal headerDal)
        {
            _headerDal=headerDal;
        }

        public Header GetById(int id)
        {
            return _headerDal.Get(id);
        }

        public void TAdd(Header entity)
        {
            _headerDal.Add(entity);
        }

        public List<Header> TGetList()
        {
            return _headerDal.GetAll();
        }

        public void TRemove(Header entity)
        {
            _headerDal.Delete(entity);
        }

        public void TUpdate(Header entity)
        {
            _headerDal.Update(entity);
        }
    }
}
