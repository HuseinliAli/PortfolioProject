using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Abstract
{
    public interface IGenericDal<T> where T : class, IEntity, new()
    {
        T Get(int id);

        List<T> GetAll();

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);  
    }
}
