using Access.Abstract;
using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectManager : IGenericService<Project>
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal=projectDal;
        }

        public Project GetById(int id)
        {
            return _projectDal.Get(id);
        }

        public void TAdd(Project entity)
        {
            _projectDal.Add(entity);
        }

        public List<Project> TGetList()
        {
            return _projectDal.GetAll();
        }

        public void TRemove(Project entity)
        {
            _projectDal.Delete(entity);
        }

        public void TUpdate(Project entity)
        {
            _projectDal.Update(entity);
        }
    }
}
