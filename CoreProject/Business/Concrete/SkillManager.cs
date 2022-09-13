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
    public class SkillManager : IGenericService<Skill>
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal=skillDal;
        }

        public Skill GetById(int id)
        {
            return _skillDal.Get(id);
        }

        public void TAdd(Skill entity)
        {
            _skillDal.Add(entity);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetAll();
        }

        public void TRemove(Skill entity)
        {
            _skillDal.Delete(entity);
        }

        public void TUpdate(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
