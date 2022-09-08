using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class About : IEntity
    {
        public int AboutID { get; set; }

        public int EducationID { get; set; }

        public string AboutImageUrl { get; set; }

        public string AboutTitle { get; set; }

        public string AboutDescription { get; set; }

    }
}
