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
    public class SocialMediaManager : IGenericService<SocialMedia>
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal=socialMediaDal;
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.Get(id);
        }

        public void TAdd(SocialMedia entity)
        {
            _socialMediaDal.Add(entity);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDal.GetAll();
        }

        public void TRemove(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
