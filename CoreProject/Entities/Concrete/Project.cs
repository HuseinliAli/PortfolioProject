using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Project : IEntity
    {
        [Key]
        public int ProjectID { get; set; }

        public int CategoryID { get; set; }

        public string ProjectName { get; set; }

        public string ProjectImageUrl { get; set; }

        public string ProjectUrl { get; set; }

        public Category Category { get; set; }
    }
}
