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
    public class CategoryManager : IGenericService<Category>
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal=categoryDal;
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(id);
        }

        public void TAdd(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetAll();
        }

        public void TRemove(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
