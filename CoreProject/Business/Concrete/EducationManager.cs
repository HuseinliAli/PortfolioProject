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
    public class EducationManager : IGenericService<Education>
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal=educationDal;
        }

        public Education GetById(int id)
        {
           return _educationDal.Get(id);
        }

        public void TAdd(Education entity)
        {
            _educationDal.Add(entity);
        }

        public List<Education> TGetList()
        {
            return _educationDal.GetAll();
        }

        public void TRemove(Education entity)
        {
            _educationDal.Delete(entity);
        }

        public void TUpdate(Education entity)
        {
            _educationDal.Update(entity);
        }
    }
}
