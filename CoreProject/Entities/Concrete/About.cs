using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class About : IEntity
    {
        [Key]
        public int AboutID { get; set; }

        public int EducationID { get; set; }

        public string AboutImageUrl { get; set; }

        public string AboutTitle { get; set; }

        public string AboutDescription { get; set; }

    }
}
