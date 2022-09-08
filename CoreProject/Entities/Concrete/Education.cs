using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Education : IEntity
    {
        public int EducationID { get; set; }

        public string EducationSchool { get; set; }

        public string EducationDegree { get; set; }

        public string EducationDuration { get; set; }
    }
}
