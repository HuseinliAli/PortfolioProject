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
    public class ContactManager : IGenericService<Contact>
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal=contactDal;
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(id);
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetAll();
        }

        public void TRemove(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
