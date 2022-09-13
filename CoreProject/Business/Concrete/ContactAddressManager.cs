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
    public class ContactAddressManager : IGenericService<ContactAddress>
    {
        IContactAddressDal _contactAddressDal;

        public ContactAddressManager(IContactAddressDal contactAddressDal)
        {
            _contactAddressDal=contactAddressDal;
        }

        public ContactAddress GetById(int id)
        {
            return _contactAddressDal.Get(id);
        }

        public void TAdd(ContactAddress entity)
        {
            _contactAddressDal.Add(entity);
        }

        public List<ContactAddress> TGetList()
        {
            return _contactAddressDal.GetAll();
        }

        public void TRemove(ContactAddress entity)
        {
            _contactAddressDal.Delete(entity);
        }

        public void TUpdate(ContactAddress entity)
        {
            _contactAddressDal.Update(entity);
        }
    }
}
