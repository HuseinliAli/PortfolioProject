using Access.Abstract;
using Access.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.EntityFramework
{
    public class EFEducationDal : GenericRepository<Education>, IEducationDal
    {
    }
}
